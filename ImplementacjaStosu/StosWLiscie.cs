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

        public  class Node
        {
            private T _data;
            public T Data
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
                _data = element;
            }

            // public Wezel(T e, object szczyt1)
            //  {
            //      this.e = e;
            //       this.szczyt1 = szczyt1;
            // }
        }
        bool IStos<T>.IsEmpty => (first == null);

        T IStos<T>.Peek => first.Data;
        T IStos<T>.Pop()
        {
            if (IsEmpty()) throw new StosEmptyException();
            var data = first.Data;
            first = first.Next;
            _count--;
            return data;
        }

        //public Node First { get; set; }

        public  bool IsEmpty()
        {
            return (first == null);
        }
        public T Peek()
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
        public T Pop()
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
            //List<T> lista = new Node<T>();
            //foreach (var item in element)
            //{

            //}
            //T[] temp = new T[Count];
            //for (int i = 0; i < temp.Length; i++)
            //    temp[i] = tab[i];
            //return temp;
            throw new Exception();
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node data = first;
            while (data != null)
            {
                yield return data.Data;
                data = data.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

     
    }
}
