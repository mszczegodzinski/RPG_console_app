using System.Collections.Generic;

namespace Fantasy_RPG.App.Abstract
{
    interface IService<T>
    {
        List<T> Items { get; set; }
        T GetItem(int id);
        List<T> GetAllItems();

        void AddItem(T item);

        void RemoveItem(T item);

    }
}
