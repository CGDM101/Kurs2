using System;

namespace InterfaceSegregationPrinciple
{
    public interface IAttackeable
    {
        int BluntAttack();
        int ShootArrow();
        int CastSpell();
    }

    public class Warrior : IAttackeable
    {
        public int BluntAttack() => throw new NotImplementedException();
        public int CastSpell() => throw new NotImplementedException();
        public int ShootArrow() => throw new NotImplementedException();

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
