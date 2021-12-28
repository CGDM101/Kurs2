using System;
using System.Collections.Generic;

namespace LiskovSubstitutionPrinciple
{
    public class Cat : Animal
    {
        public Cat() 
        {
            Sound = "Meeeoooww";
        }
    }

    public class PlayWithPets
    {
        public void Play()
        {
            var pets = new List<Animal>()
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

    public class Dog : Animal
    {
        public Dog()
        {
            Sound = "Wooff";
        }
    }

    public abstract class Animal
    {
        protected string Sound = "grrr";
        public virtual string Name { get; set; }
        public virtual string MakeSound() => $"{Name} is a nice {GetType().Name} who says {Sound}";

    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
