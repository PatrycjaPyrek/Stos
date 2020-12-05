using System;


namespace Stos
{
    class Program
    {
        static void Main(string[] args)
        {
            StosWTablicy<string> s = new StosWTablicy<string>(3);
            s.Push("km");
            s.Push("aa");
            s.Push("xx");
            s.Push("xx");

            Console.WriteLine(s[1]);

            foreach(var x in s.ToArrayReadOnly())
                Console.WriteLine(x);

            foreach (var x in s.ToArray())
                Console.WriteLine(x);
            s.TrimExcess();
            Console.WriteLine();
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}