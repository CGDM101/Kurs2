using System;
using System.Collections.Generic;

namespace DependencyInversionPrinciple
{
    public class Game
    {
        List<IPlayeableCharacter> Players = new List<IPlayeableCharacter>();
        public void StartGame()
        {
            Players = new List<IPlayeableCharacter>
            {
                new Warrior(),
                new Archer(),
                new Mage(),
                new Elf(),
            };
        }

        //private Warrior conan = new Warrior();
        //private Archer legolas = new Archer();
        //private Mage merlin = new Mage();
        //private Elf willFerrell = new Elf();
    }

    public interface IPlayeableCharacter
    {
        public string Name { get; set; }
        public int XP { get; set; }
        public int HP { get; set; }
        public int XPNeeded { get; set; }
        public int Level { get; set; }

    }
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

    public class Warrior : IBluntable, IPlayeableCharacter
    {
        public int BluntAttack() => throw new NotImplementedException();
    }
    public class Archer : IArcheryable, IPlayeableCharacter
    {
        public int ShootArrow() => throw new NotImplementedException();
    }
    public class Mage : IMagicable, IPlayeableCharacter
    {
        public int CastSpell() => throw new NotImplementedException();
    }
    public class Elf : IBluntable, IArcheryable, IMagicable, IPlayeableCharacter
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
