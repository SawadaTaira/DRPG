using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRPG
{
    internal class Hero
    {
        public class Warrior : Character
        {
            public Warrior() : base("戦士", 300, 50) { }
        }

        public class Mage : Character
        {
            public Mage() : base("魔法使い", 150, 30) { }
        }

        public class Archer : Character
        {
            public Archer() : base("弓使い", 200, 30) { }
        }

    }
}
