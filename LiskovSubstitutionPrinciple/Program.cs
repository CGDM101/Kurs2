using System;
using System.Collections.Generic;

namespace LiskovSubstitutionPrinciple
{
    public class Cat 
    {
        protected string Sound { get; set; } = "Meeeeoooowwwww";
        public virtual string Name { get; set; }
        public virtual string MakeSound() => $"{Name} is a nice {GetType().Name} who says {Sound}";
    }

    public class PlayWithPets
    {
        public void Play()
        {
            var pets = new List<Cat>() 
            {
                new Cat { Name = "Misse" },
                new Dog { Name = "Voffsing" },
            };
            foreach (var pet in pets)
            {
                Console.WriteLine(pet.MakeSound());
            }


            //Cat c = new Cat() { Name = "Misse" };
            //Console.WriteLine(c.MakeSound());
        }
    }

    public class Dog : Cat
    {
        public Dog()
        {
            Sound = "Wooff";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
