using System;
using System.Collections.Generic;
using System.Text;

namespace Fantasy_RPG.domain.Entity
{
    public class Character
    {
        public string Name { get; set; } 
        public int Strength { get; set; }
        public int Power { get; set; }
        public int HP { get; set; }
        public int Gold { get; set; }
        public List<Item> Items { get; set; }


    }
}
