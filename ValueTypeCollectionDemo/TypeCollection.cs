using System;
using System.Collections.Generic;
using System.Linq;

namespace ValueTypeCollectionDemo
{
    public class TypeCollection<T> where T : struct
    {
        private List<T> items;

        public TypeCollection()
        {
            items = new List<T>();
        }

        public void AddItem(T item)
        {
            items.Add(item);
        }

        public T GetItem(int index)
        {
            if (index >= 0 && index < items.Count)
            {
                return items[index];
            }
            else
            {
                throw new IndexOutOfRangeException("Index is out of range");
            }
        }

        public List<T> GetSortedDescending()
        {
            List<T> sortedList = new List<T>(items);
            sortedList.Sort();
            sortedList.Reverse();
            return sortedList;
        }
    }
}
