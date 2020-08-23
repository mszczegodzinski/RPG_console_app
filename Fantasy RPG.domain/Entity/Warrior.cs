using System.Collections.Generic;

namespace Fantasy_RPG.domain.Entity
{
    public class Warrior : Character
    {
        bool SecondWeapon { get; set; }
        public Warrior(int id, string name, int strength, int power, int hp, int gold, List<Item> items, bool secondWeapon)
            : base(id, name, strength, power, hp, gold, items)
        {
            SecondWeapon = secondWeapon;
        }

        public override string ToString() => "Warrior";
    }
}
