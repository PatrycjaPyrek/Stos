using Stos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Stos
{
    public class StosWLiscie<T> : IStos<T>
    {

        private Node first;
        private int _count = 0;
        public int Count { get
            { return _count; } }

        T IStos<T>.Peek => throw new NotImplementedException();

        bool IStos<T>.IsEmpty => throw new NotImplementedException();

        //public Node First { get; set; }

        public  class Node
        {
            private Node _data;
            public Node Data
            {
                get { return _data; }
                set { _data = value; }
            }
            private Node _next;
            public Node Next
            {
                get { return _next; }
                set { _next = value; }
            }
            public Node(T element)
            {
                Data = _data;

            }

            // public Wezel(T e, object szczyt1)
            //  {
            //      this.e = e;
            //       this.szczyt1 = szczyt1;
            // }
        }
       

        public bool IsEmpty()
        {
            return first == null;
        }

      
       
        public Node Peek()
        {
            if (IsEmpty())
            {
                throw new StosEmptyException();
            }
             return first.Data;
        }

        public void Push(T e)
        {
            Node currentTop = first;

            first = new Node(e)
            {
                Next = currentTop
        };
           
            _count++;
           
        }
        public Node Pop()
        {
            if (IsEmpty()) throw new StosEmptyException();
            var data = first.Data;
            first = first.Next;
            _count--;
           return data;
          
        }
        //Boolean IsEmpty()
        //{
        //    return (szczyt == null);
        //}


       // public int Count => throw new NotImplementedException();

       
        
        public T this[int index] => throw new NotImplementedException();

       // public void Push(T value) => szczyt = new Node(T value);

       

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public void TrimExcess()
        {
            throw new NotImplementedException();
        }

        public T[] ToArray()
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        T IStos<T>.Pop()
        {
            throw new NotImplementedException();
        }
    }
}
