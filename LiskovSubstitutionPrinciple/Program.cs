using System;

namespace LiskovSubstitutionPrinciple
{
    public class Cat 
    {
        private string Sound { get; set; } = "Meeeeoooowwwww";
        public string Name { get; set; }
        public string MakeSound() => $"{Name} is a nice {GetType().Name} who says {Sound}";
    }

    public class PlayWithPets
    {
        public void Play()
        {
            Cat c = new Cat() { Name = "Misse" };
            Console.WriteLine(c.MakeSound());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
