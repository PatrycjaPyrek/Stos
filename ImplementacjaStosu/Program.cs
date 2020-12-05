using System;

namespace Stos
{
    class Program
    {
        static void Main(string[] args)
        {
            StosWTablicy<string> s = new StosWTablicy<string>(2);
            s.Push("km");
            s.Push("aa");
            s.Push("xx");
            s.Push("sa");
            s.TrimExcess();
            foreach (var x in s.ToArray())
                Console.WriteLine(x);

            Console.WriteLine();
            Console.WriteLine(s.Count);
        }
    }
}