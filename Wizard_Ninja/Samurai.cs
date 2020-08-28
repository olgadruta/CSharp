using System;
using System.Collections.Generic;

namespace Wizard_Ninja
{
    class Samurai : Human
    {
        public Samurai(string name) : base(name)
        {
            health = 200;
        }
        public override void GetInfo()
        {
            base.GetInfo();
        }
        public override int Attack(Human target)
        {
            int dmg = Strength * 3;
            target.Health -= dmg;
            if(target.Health <50)
            {
                target.Health=0;
            }
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.Health;
        }
        public int Meditate()
        {
            health = 200;
            return health;
        }
    }

}
