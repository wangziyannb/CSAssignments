using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment1.Assignment04_Generics
{
    public class MyStack<T>
    {
        class ListNode<O>
        {
            public O Value;
            public ListNode<O> Prev;
            public ListNode<O> Next;
            public ListNode(O value, ListNode<O> prev, ListNode<O> next)
            {
                Value = value;
                Prev = prev;
                Next = next;
            }
        }
        ListNode<T> head;
        ListNode<T> tail;
        int count;

        public MyStack()
        {
            count = 0;
        }

        public T Pop()
        {
            if (count == 0)
            {
                throw new Exception("Empty Stack");
            }
            T t = tail.Value;
            if (count == 1)
            {
                tail = null;
                head = null;
            }
            else
            {
                tail = tail.Prev;
            }
            count--;
            return t;
        }

        public void Push(T t)
        {
            if (count == 0)
            {
                head = new ListNode<T>(t, null, null);
                tail = head;
            }
            else
            {
                tail.Next = new ListNode<T>(t, tail, null);
                tail = tail.Next;
            }
            count++;
        }

        public int Count()
        {
            return count;
        }

        public void Test()
        {
            MyStack<int> myStack = new();
            Console.WriteLine("Add 0, 1, 2 to this stack and pop them out");
            myStack.Push(0);
            myStack.Push(1);
            myStack.Push(2);
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Pop());
        }
    }
}
