using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRPG
{
    internal class Enemy
    {
        public class Goblin : Character
        {
            public Goblin() : base("ゴブリン", 50, 10) { }
        }

        public class Dullahan : Character
        {
            public Dullahan() : base("デュラハン", 120, 15) { }
        }

        public class Dragon : Character
        {
            public Dragon() : base("ドラゴン", 200, 30) { }
        }

    }
}
