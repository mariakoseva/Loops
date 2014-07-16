using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersNotDevisibleBYSevenAndThree
{
    class NumbersNotDevisibleBYSevenAndThree
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                if (i % 3==0 && i % 7==0)
                {
                    Console.WriteLine("The numbers are {i}", );
                }
            }
        }
    }
}
