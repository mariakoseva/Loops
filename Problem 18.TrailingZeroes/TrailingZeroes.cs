using System;
using System.Numerics;

class TrailingZeroesInNFactorial
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger factorial = 1;
        int count = 0;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }

        string factorialString = factorial.ToString();
        for (int i = factorialString.Length - 1; i >= 0; i--)
        {
            if (factorialString[i] == '0')
            {
                count++;
            }
            else
            {
                break;
            }
        }
        Console.WriteLine(count);
    }
}