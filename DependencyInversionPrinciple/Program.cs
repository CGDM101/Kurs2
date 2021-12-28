using System;
using System.Collections.Generic;

namespace DependencyInversionPrinciple
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

    public class Game
    {
        public void BluntAttack(List<IBluntable> warriors)
        {
            foreach (var warrior in warriors)
            {
                warrior.BluntAttack();
            }
        }
        public void ArrowAttack(List<IArcheryable> archers)
        {
            foreach (var archer in archers)
            {
                archer.ShootArrow();
            }
        }
        public void MagicAttack(List<IMagicable> mages)
        {
            foreach (var mage in mages)
            {
                mage.CastSpell();
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
