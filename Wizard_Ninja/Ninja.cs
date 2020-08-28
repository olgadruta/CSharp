using System;
using System.Collections.Generic;

namespace Wizard_Ninja
{
    class Ninja : Human
    {
        public Ninja(string name) : base(name)
        {
            Dexterity = 175;
        }
        public override void GetInfo()
        {
            base.GetInfo();
        }
        public override int Attack(Human target)
        {   
            Random rand = new Random();
            int dmg = Dexterity * 5;
            if (rand.Next(1,10)<3)
            {
                dmg +=10;
            }
            target.Health -= dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.Health;
        }
        public int Steal (Human target)
        {
            target.Health -= 5;
            this.Health +=5;
            // return target.Health;
            return this.Health;
        }

    }

}
