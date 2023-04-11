using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment1.Assignment04_Generics
{
    public class MyList<T>
    {
        T[] values;
        private int tail;
        public int Count
        {
            get
            {
                return tail + 1;
            }
        }
        public MyList()
        {
            tail = -1;
            values = new T[5];
        }

        public void Add(T element)
        {
            CheckFull();
            values[++tail] = element;
        }

        public T Remove(int index)
        {
            if (index > tail || index < 0)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                T element = values[index];
                for (int i = index; i < tail; i++)
                {
                    values[i] = values[i + 1];
                }
                tail--;
                return element;
            }
        }

        public bool Contains(T element)
        {
            for (int i = 0; i <= tail; i++)
            {
                if (values[i].Equals(element))
                {
                    return true;
                }
            }
            return false;
        }

        public void Clear()
        {
            values = new T[5];
            tail = -1;
        }

        public void InsertAt(T element, int index)
        {
            if (tail == -1 && index == 0)
            {
                Add(element);
                return;
            }
            if (index > tail || index < 0)
            {
                // out of bound
                throw new IndexOutOfRangeException();
            }
            else
            {
                CheckFull();
                for (int i = tail + 1; i > index; i--)
                {
                    values[i] = values[i - 1];
                }
                values[index] = element;
                tail++;
            }
        }

        public void DeleteAt(int index)
        {
            // Seem same with Remove()
            Remove(index);
        }

        public T Find(int index)
        {
            if (index > tail || index < 0)
            {
                // out of bound
                throw new IndexOutOfRangeException();
            }
            return values[index];
        }

        public void Debug()
        {
            if (values != null)
            {
                for (int i = 0; i <= tail; i++)
                {
                    Console.Write(" " + values[i]);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("List is empty now");
            }
        }

        private void CheckFull()
        {
            if (values.Length == tail + 1)
            {
                T[] temp = new T[values.Length * 2];
                values.CopyTo(temp, 0);
                values = temp;
            }
        }

        public void Test()
        {
            MyList<string> myList = new();
            Console.WriteLine("Add hello to this List");
            myList.Add("hello");
            myList.Debug();
            Console.WriteLine("Add world to this List");
            myList.Add("world");
            myList.Debug();
            Console.WriteLine("Add 1, 2, 3, 4 to this List");
            myList.Add("1");
            myList.Debug();
            myList.Add("2");
            myList.Debug();
            myList.Add("3");
            myList.Debug();
            myList.Add("4");
            myList.Debug();
            Console.WriteLine("Show the current number of value");
            Console.WriteLine(myList.Count);
            Console.WriteLine("Remove the last one");
            myList.Remove(myList.Count - 1);
            myList.Debug();
            Console.WriteLine("Check if contains the removed value (4)");
            Console.WriteLine(myList.Contains("4"));
            Console.WriteLine("Check if contains a value that inside of it (2)");
            Console.WriteLine(myList.Contains("2"));
            Console.WriteLine("Clear the list");
            myList.Clear();
            myList.Debug();
            Console.WriteLine("Insert 'a' to index 0");
            myList.InsertAt("a", 0);
            myList.Debug();
            Console.WriteLine("Insert 'b' to index 0");
            myList.InsertAt("b", 0);
            myList.Debug();
            Console.WriteLine("Delete value in index 0");
            myList.DeleteAt(0);
            myList.Debug();
            Console.WriteLine("Retrive value in index 0");
            Console.WriteLine(myList.Find(0));
        }
    }
}
