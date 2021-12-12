using System;

namespace TomtensLeksaksfabrik
{
    public enum ToyModel
    {
        Airplane,
        Ragdoll,
        HauntedDoll,
        Ball,
        RubberDuck,
    }
    public interface IToy
    {
        string Name { get; set; }
        ToyModel Model { get; set; }
    }
    public static class ToyFactory
    {
        public static IToy Create(ToyModel toy)
        {
            switch (toy)
            {
                // maSSor med kod:
                case ToyModel.Airplane:
                    break;
                case ToyModel.Ragdoll:
                    break;
                case ToyModel.HauntedDoll:
                    break;
                case ToyModel.Ball:
                    break;
                case ToyModel.RubberDuck:
                    break;
                default:
                    break;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
