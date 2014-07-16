using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersFromOneToTen
{
    class NumbersFromOneToTen
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number:");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }
    }
}
