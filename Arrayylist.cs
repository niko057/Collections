using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Collections
{
    public class CustomArray
    {
        private object[] items;
        private int capacity;
        private int count;

        public int Capacity
        {
            get { return capacity; }
        }

        public int Count
        {
            get { return count; }
        }

        public CustomArray(int capacity)
        {
            this.capacity = capacity;
            this.count = 0;
            this.items = new object[capacity];
        }

        public void Add(object item)
        {
            if (count < capacity)
            {
                items[count] = item;
                count++;
            }
            else
            {
                
                capacity *= 2;
                object[] newItems = new object[capacity];
                Array.Copy(items, newItems, count);
                items = newItems;
                items[count] = item;
                count++;
            }
        }

        public void Remove(object item)
        {
            for (int i = 0; i < count; i++)
            {
                if (items[i].Equals(item))
                {
                    RemoveAt(i);
                    return;
                }
            }
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException();
            }

            for (int i = index; i < count - 1; i++)
            {
                items[i] = items[i + 1];
            }

            count--;
        }

        public void TrimToSize()
        {
            if (count < capacity)
            {
                capacity = count;
                object[] newItems = new object[capacity];
                Array.Copy(items, newItems, count);
                items = newItems;
            }
        }

        public void AddRange(object[] collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException(nameof(collection));
            }

            int newCount = count + collection.Length;

            if (newCount > capacity)
            {
                
                while (capacity < newCount)
                {
                    capacity *= 2;
                }

                object[] newItems = new object[capacity];
                Array.Copy(items, newItems, count);
                items = newItems;
            }

            Array.Copy(collection, 0, items, count, collection.Length);
            count = newCount;
        }

        public void PrintAll()
        {
            foreach (object element in items)
            {
                Console.WriteLine("Daxil etdiyin elementler:");
                Console.WriteLine(element);
            }
        }
    }
}
