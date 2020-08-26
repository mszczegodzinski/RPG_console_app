using Fantasy_RPG.App.Abstract;
using Fantasy_RPG.domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fantasy_RPG.App.Common
{
    public class BaseServiceLocation<T> : IService<T> where T : Location
    {
        public List<T> Items { get; set; }

        public BaseServiceLocation()
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

        public int GetLength()
        {
            return Items.Count();
        }

    }
}
