using System;

class MatrixOfNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool inRange = n >= 1 && n <= 20;
        if (inRange)
        {
            for (int row = 1; row <= n; row++)
            {
                for (int column = 0; column < n; column++)
                {
                    Console.Write(row + column + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
}