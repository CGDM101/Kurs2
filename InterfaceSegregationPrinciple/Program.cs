using System;

namespace InterfaceSegregationPrinciple
{
    public interface IAttackeable
    {
        int BluntAttack();
        int ShootArrow();
        int CastSpell();
    }


    public interface IBluntable
    {
        int BluntAttack();
    }
    public interface IArcheryable
    {
        int ShootArrow();
    }
    public interface IMagicable
    {
        int CastSpell();
    }
    
    public class Warrior : IBluntable
    {
        public int BluntAttack() => throw new NotImplementedException();
    }
    public class Archer : IArcheryable
    {
        public int ShootArrow() => throw new NotImplementedException();
    }
    public class Mage : IMagicable
    {
        public int CastSpell() => throw new NotImplementedException();
    }
    public class Elf : IBluntable, IArcheryable, IMagicable
    {
        public int BluntAttack() => throw new NotImplementedException();
        public int ShootArrow() => throw new NotImplementedException();
        public int CastSpell() => throw new NotImplementedException();
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
