using System;

class RandomNumberGivenInRange
{
    static void Main()
    {
        System.Console.WriteLine("Console write 3 numbers:,n, min & max, n is (min;max) and and randomise it");
        System.Console.WriteLine("n=");
        int n = int.Parse(Console.ReadLine());

        Random random = new Random();
        for (int i = 0; i < n; i++)
            Console.Write(random.Next(1, n + 1) + " ");
        Console.WriteLine();
    }
}
