using System.Collections.Generic;

namespace Fantasy_RPG.domain.Entity
{
    public class Amazon : Character
    {
        bool Bow { get; set; }
        public Amazon(int id, string name, int strength, int power, int hp, int gold, List<Item> items, bool bow)
            : base(id, name, strength, power, hp, gold, items)
        {
            Bow = bow;
        }

        public override string ToString() => "Amazon";
    }
}
