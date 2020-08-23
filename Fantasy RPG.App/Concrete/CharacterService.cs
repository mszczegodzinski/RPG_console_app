using Fantasy_RPG.App.Common;
using Fantasy_RPG.domain.Entity;
using System.Collections.Generic;

namespace Fantasy_RPG.App.Concrete
{
    public class CharacterService : BaseService<Character>
    {
        public CharacterService()
        {
            Initialize();
        }

        private void Initialize()
        {
            List<Item> Items = new List<Item>();
            AddItem(new Warrior(1, "Name", 4, 1, 50, 0, Items, null));
            AddItem(new Amazon(2, "Name", 3, 2, 50, 0, Items, null));
        }


    }
}
