using Fantasy_RPG.App.Abstract;
using Fantasy_RPG.domain.Entity;
using System.Collections.Generic;
using System.Linq;

namespace Fantasy_RPG.App.Common
{
    public class BaseService<T> : IService<T> where T : Character
    {
        public List<T> Items { get; set; }

        public BaseService()
        {
            Items = new List<T>();
        }

        public void AddItem(T item)
        {
            Items.Add(item);
        }

        public T GetItem(int id)
        {
            return Items.FirstOrDefault(i => i.Id == id);
        }

        public void RemoveItem(T item)
        {
            Items.Remove(item);
        }

        public List<T> GetAllItems()
        {
            return Items;
        }

    }
}
