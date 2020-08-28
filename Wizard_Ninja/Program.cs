using System;
using System.Collections.Generic;

namespace Wizard_Ninja
{
    class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        protected int health;
        public int Health
        {
            get { return health; }
            set { health = value; }
        }
        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }
        public Human(string name, int strength, int intelligence, int dexterity, int health)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            this.health = health;
        }
        // Build Attack method
        public virtual void GetInfo()
        {
            System.Console.WriteLine($"Name: {Name}");
            System.Console.WriteLine($"Intelligence: {Intelligence}");
            System.Console.WriteLine($"Strength: {Strength}");
            System.Console.WriteLine($"Dexterity: {Dexterity}");
            System.Console.WriteLine($"health: {Health}");
        }
        public virtual int Attack(Human target)
        {
            int dmg = Strength * 3;
            target.health -= dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.Health;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Wizard newWizard = new Wizard("Alec");
            newWizard.GetInfo();
            Ninja newNinja = new Ninja("fun");
            newNinja.GetInfo();
            Samurai newSamurai = new Samurai("happy");
            newSamurai.GetInfo();
            Human Alec = new Human("Alec");
            Wizard Nick = new Wizard("Nick");
            Console.WriteLine(Nick.Attack(Alec));
            Ninja George = new Ninja("George");
            Console.WriteLine(George.Attack(Alec));
            Samurai Mike = new Samurai("Mike");
            Console.WriteLine(Mike.Attack(Alec));
            Console.WriteLine($"Healed human now has this much health  {Nick.Heal(Alec)}");
            Console.WriteLine($"Samurai health is now {newSamurai.Meditate()}");
            // System.Console.WriteLine($"Ninja health is now {newNinja.Steal(Alec)}");
            System.Console.WriteLine($"Ninja health is now {newNinja.Steal(George)}");
        }
    }
}

