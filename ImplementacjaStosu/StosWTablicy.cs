using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Stos
{
    public class StosWTablicy<T> : IStos<T>
    {
        private T[] tab;
        private int szczyt = -1;

        public StosWTablicy(int size = 10)
        {
            tab = new T[size];
            szczyt = -1;
        }

        public T Peek => IsEmpty ? throw new StosEmptyException() : tab[szczyt];

        public int Count => szczyt + 1;

        public bool IsEmpty => szczyt == -1;

        public T this[int index]=>
            (index > Count - 1)?
            throw new IndexOutOfRangeException() :
            tab[index];
        /*{
            get
            {
                /*     T temp;
                     var tablica = new T[tab.Length];
                     if (index >= 0 && index <= tab.Length - 1)
                         temp = tab[index];
                     else
                         throw new ArgumentOutOfRangeException();
                     return temp;
             
                
                    

            }
        }*/

        public void Clear() => szczyt = -1;

        public T Pop()
        {
            if (IsEmpty)
                throw new StosEmptyException();

            szczyt--;
            return tab[szczyt + 1];
        }

        public void Push(T value)
        {
            if (szczyt == tab.Length - 1)
            {
                Array.Resize(ref tab, tab.Length * 2);
            }

            szczyt++;
            tab[szczyt] = value;
            
        }

        public void TrimExcess()
        {
            int zajete = tab.Length;
            int ileWolnych = 0;
            foreach (var item in tab)
            {
                if (item == null)
                {
                    ileWolnych += 1;
                    
                }
            }
            if (ileWolnych > Math.Round((zajete * 0.1)))
            {
                int utnij = ((int)(ileWolnych - ((zajete) * 0.1)));
                Array.Resize(ref tab, (zajete - utnij));
            }
        }

        public T[] ToArray()
        {
            //return tab;  //bardzo źle - reguły hermetyzacji

            //poprawnie:
            T[] temp = new T[szczyt + 1];
            for (int i = 0; i < temp.Length; i++)
                temp[i] = tab[i];
            return temp;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return this[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)this;
        }
        public System.Collections.ObjectModel.ReadOnlyCollection<T> ToArrayReadOnly()
        {
            return Array.AsReadOnly(tab);
        }
    }
}

  