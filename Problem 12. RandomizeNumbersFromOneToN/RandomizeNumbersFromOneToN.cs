using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_12.RandomizeNumbersFromOneToN
{
    class RandomizeNumbersFromOneToN
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int[] array = new int[number];
            for (int index = 0; index < number; index++)
            {
                array[index] = index + 1;
            }
 
            Random random = new Random();
            foreach (int index in array)
            {
                int randNum = random.Next(0, number);
                int temp = array[randNum];
                array[randNum] = array[0];
                array[0] = temp;
            }
            Console.WriteLine(String.Join(" ", array));
        
        }
    }
}
