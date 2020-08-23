namespace Fantasy_RPG.domain.Entity
{
    public class Undead
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Power { get; set; }

        public Undead(string name, int strength, int power)
        {
            Name = name;
            Strength = strength;
            Power = power;
        }
    }
}
