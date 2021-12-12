using System;

namespace SantaVersusKrampus
{
    public static class ChristmasVisitorFabric
    {
        public static IChristmasVisitor GetVisitor(bool hasBeenGood) { /* Massor med */}
    }

    public interface IChristmasVisitor
    {
        public string Name { get; set; }
        public string Gift { get; set; }
    }
    public class Santa : IChristmasVisitor
    {
        public string Name { get; set; } = "Santa";
        public string Gift { get; set; } = "A wonderful toy";
    }
    public class Krampus : IChristmasVisitor
    {
        public string Name { get; set; } = "Krampus";
        public string Gift { get; set; } = "Coat";
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
