using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Součet
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;

            Console.Write("Zadejte 1. číslo: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Zadejte 2. číslo: ");
            b = int.Parse(Console.ReadLine());

            int c = a + b;
            Console.WriteLine("Výsledek je: {0}", c);
            Console.ReadKey();
        }
    }
}
