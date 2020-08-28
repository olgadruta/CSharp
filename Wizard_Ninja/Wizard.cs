using System;
using System.Collections.Generic;

namespace Wizard_Ninja
{
    class Wizard : Human
    {
        public Wizard(string name) : base(name)
        {
            Intelligence = 50;
            health = 100;
        }

        public override void GetInfo()
        {
            base.GetInfo();
        }
        public override int Attack(Human target)
        {
            int dmg = Intelligence * 5;
            target.Health -= dmg;
            // Health += dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.Health;
        }
        public int Heal(Human target)
        {
            target.Health += Intelligence * 10;
            return target.Health;
        }
    }
}
