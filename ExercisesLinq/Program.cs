using System;
using System.Collections.Generic;
using System.Linq;

namespace ExercisesLinq
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class PersonJOIN
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Pet
    {
        public string Name { get; set; }
        public PersonJOIN Owner { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region del ett
            // Exempel på vad man kan göra med string:
            var Namn = new List<string> { "Marcus", "Peter", "Linda", "Ronja", "Sören" };
            var filtrerade = new List<string>();
            foreach (var item in Namn)
            {
                if (item.StartsWith("M")) 
                {
                    filtrerade.Add(item);
                }
            }
            foreach (var item in filtrerade)
            {
                Console.WriteLine(item);
            }

            // Med Linq (method syntax):
            Namn.Where(n => n.StartsWith('M')).ToList().ForEach(x => Console.WriteLine(x)); // to list för att ForEach ska fungera!

            // Eller med vanlig foreach:
            var filter = Namn.Where(n => n.StartsWith('M'));
            foreach (var item in filter)
            {
                Console.WriteLine(item);
            }

            // Query syntax istället för method syntax:
            var filter2 = from name in Namn
                          where name.StartsWith('M')
                          select name;

            // Exempel på vad man kan göra med int:
            var tal = new int[] { 1, 23, 23, 423, 423, 23, 23, 4, 24, 23, 4, 24, 2, 42, 4, 2, 23, 24 };
            
            var sorteradeTal = tal.OrderBy(x => x);
            var högstaVärdet = tal.Max();
            var minstaVärdet = tal.Min();
            var summa = tal.Sum();
            var medel = tal.Average();
            var summaTalMerÄn100 = tal.Where(x => x > 100).Sum();
            var summaTalMerÄn100OchMindreÄn200 = tal.Where(x => x > 100 && x < 200).Sum();
            #endregion

            #region del två LINQ OCH OBJEKT
            var people = new Person[]
            {
                new Person{ Name="Jack Nicholson",Age=83},
                new Person{ Name="Nicholas Cage",Age=56},
                new Person{ Name="Bruce Willis",Age=65},
            };

            // Sortera utefter ålder:
            var peopleByAge = from person in people
                              orderby person.Age
                              select person;
            // Alternativt:
            var peopleByAge2 = people.OrderBy(x => x.Age);

            // Skriver ut:
            foreach (var item in peopleByAge) // peopleByAge2
            {
                Console.WriteLine($"{item.Name} {item.Age}"); // Mellanslag!
            }

            // Medelålder:
            var meanAge = people.Average(x => x.Age);

            // Contains:
            var hasNic = from actor in people
                         where actor.Name.Contains("Nic")
                         select actor;
            // Alternativt:
            var hasNic2 = people.Where(actor => actor.Name.Contains("Nic"));
            #endregion

            #region del tre SORTERING fråga!
            // Att sortera på flera kriterier:
            var sortedActors = people.OrderBy(actor => actor.Name).OrderBy(actor => actor.Age); // Funkar men fel resultat!
            //var sortedActorsCOMPILEERROR = people.OrderBy(actor => actor.Name && actor.Age);
            var sortedActorsCorrectly = people.OrderBy(actor => actor.Name).ThenBy(actor => actor.Age);
            foreach (var item in sortedActorsCorrectly)
            {
                Console.WriteLine("yngsta först:" + item.Name + " " + item.Age);
            }
            // Descending ålder i st f ascending:
            var sortedAscending = people.OrderBy(actor => actor.Name).ThenByDescending(actor => actor.Age);
            foreach (var item in sortedAscending)
            {
                Console.WriteLine("äldsta först:" + item.Name + " " + item.Age);
            }
            #endregion

            #region del fyra JOIN CLASSES
            PersonJOIN magnus = new PersonJOIN { FirstName = "Magnus", LastName = "Hedlund" };
            PersonJOIN terry = new PersonJOIN { FirstName = "Terry", LastName = "Adams" };
            PersonJOIN charlotte = new PersonJOIN { FirstName = "Charlotte", LastName = "Weiss" };
            PersonJOIN arlene = new PersonJOIN { FirstName = "Arlene", LastName = "Huff" };
            PersonJOIN rui = new PersonJOIN { FirstName = "Rui", LastName = "Raposo" };

            Pet barley = new Pet { Name = "Barley", Owner = terry };
            Pet boots = new Pet { Name = "Boots", Owner = terry };
            Pet whiskers = new Pet { Name = "Whiskers", Owner = charlotte };
            Pet bluemoon = new Pet { Name = "Blue Moon", Owner = rui };
            Pet daisy = new Pet { Name = "Daisy", Owner = magnus };

            List<PersonJOIN> persons = new List<PersonJOIN> { magnus, terry, charlotte, arlene, rui };
            List<Pet> pets = new List<Pet> { barley, boots, whiskers, bluemoon, daisy };

            // A collection of person-pet pairs. Each element is an anonymous type containing both the person's name and the pet's name:
            var query = from person in persons
                        join pet in pets on person equals pet.Owner
                        select new { OwnerName = person.FirstName, PetName = pet.Name };

            foreach (var ownerAndPet in query)
            {
                Console.WriteLine($"\"{ownerAndPet.PetName }\" is owned by {ownerAndPet.OwnerName}");
            }
            #endregion

            #region EXTENSTIONS
            static int Add(int x, int y) { return x + y; }
            var numbers = new List<int> { 6, 2, 8, 3 };
            int sum = numbers.Aggregate(func: Add); // Tala om för Lnq att använda Add, genom att använda Aggregate-metoden.
           
            // Se klass ActorExtension nedan!
   
            #endregion
        }
    }
    public static class ActorExtension // Denna klass innehåller förlängningar för just skådespelarna. När vi använder objekt av typen 'Person' kommer GetIMDBUrl föreslås av VS som funktion till den klassen.
    {
        public static string GetIMDBUrl(this Person actor)
        {
            return "https://www.imdb.com/find?s=all&q=" + actor.Name.Replace(" ", "+");
        }
    }
    // Regler: Klassen måste vara statisk; Metoden ska vara statisk; Första paremetern i metoden ska föregås av this.
    // This talar om för metoden att den ska koppla sig till den sortens objekt. Ex: This string kopplar sig till stringobjekt.

    // Exempel på extensions:
    public static class StringExtension
    {
        public static string[] SplitBySpace(this string text)
        {
            return text.Split();
        }
        public static string JoinWithSpace(this string[] text)
        {
            return string.Join(' ', text);
        }
    } // Nu har stringojektet de metoderna tillgängliga!

}
