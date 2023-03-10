using System;

namespace ManipulaVar
{
    class Program
    {
        static void Main(string[] args)
        {
            string val;
            int x;
            int m2;
            
            val = args [0];
            x = int.Parse(val);
            m2 = x;
            x++;
            --m2;
            
            Console.WriteLine( x);
            Console.WriteLine(m2);
        }
    }
}
