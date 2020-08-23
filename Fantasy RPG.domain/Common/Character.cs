using System.Collections.Generic;

namespace Fantasy_RPG.domain.Entity
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Power { get; set; }
        public int HP { get; set; }
        public int Gold { get; set; }
        public List<Item> Items { get; set; }

        public Character(int id, string name, int strength, int power, int hP, int gold, List<Item> items)
        {
            Id = id;
            Name = name;
            Strength = strength;
            Power = power;
            HP = hP;
            Gold = gold;
            Items = items;
        }
    }
}
