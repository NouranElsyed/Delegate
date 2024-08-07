using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class ImplementedList<T>
    {
        public List<T> list;

        public ImplementedList()
        {
            list = new List<T>();
        }

        public bool Exist(Predicate<T> predicate)
        {
            foreach (var item in list)
            {
                if (predicate(item))
                    return true;
            }
            return false;
        }

        public T Find(Predicate<T> match)
        {
            foreach (T item in list)
            {
                if (match(item))
                {
                    return item;
                }
            }
            return default(T);
        }


        public List<T> FindAll(Predicate<T> match)
        {
            List<T> result = new List<T>();
            foreach (T item in list)
            {
                if (match(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }
        public int FindIndex(Predicate<T> predicate)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (predicate(list[i]))
                    return i;
            }
            return -1;
        }

        public T FindLast(Predicate<T> predicate)
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (predicate(list[i]))
                    return list[i];
            }
            return default;
        }


        public int FindLastIndex(Predicate<T> predicate)
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (predicate(list[i]))
                    return i;
            }
            return -1;
        }


        public void Foreach(Action<T> action)
        {
            foreach (var item in list)
            {
                action(item);
            }
        }

        public bool TrueForAll(Predicate<T> predicate)
        {
            foreach (var item in list)
            {
                if (!predicate(item))
                    return false;
            }
            return true;
        }


        public int Count => list.Count;

        public T this[int index]
        {
            get => list[index];
            set => list[index] = value;
        }
        public void Add(T item)
        {
            list.Add(item);
        }
    }
}
