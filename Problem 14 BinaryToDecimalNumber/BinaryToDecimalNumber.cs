using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryToDecimalNumber
{
    class BinaryToDecimal
    {
        static void Main()
        {
            double sum = 0;
            int number = int.Parse(Console.ReadLine()); // binary number
            int strn = number.ToString().Length; //how many digits has the number
            for (int i = 0; i < strn; i++)
            {
                int lastDigit = number % 10; // get the last digit
                sum = sum + lastDigit * (Math.Pow(2, i));
                number = number / 10; //remove the last digit
            }
            Console.WriteLine(sum);
        }
    }
}