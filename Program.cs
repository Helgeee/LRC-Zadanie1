using System;

namespace Zadanie_1
{
    class Program
    {
        private static void Main()
        {
            Console.WriteLine("Введите X и Y");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
           
            int z = max( x, 2 * y - x) + max(5 * x + 3 * y, y);
            Console.WriteLine(z);
        }

        private static int max(int p0, int p1)
        {
            return p0 > p1 ? p0 : p1;
        }
    }
}