using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int x, y;
            x = 10;
            y = 3;
            float result = (float) x /y ;
            Console.WriteLine($"result={result}");
            */
            string name = "George";
            ChangeName(ref name);
            
            Console.WriteLine($"name= {name}");

        }

        static void ChangeName(ref string x)
        {
            x = "Nistor";
        }
    }
}