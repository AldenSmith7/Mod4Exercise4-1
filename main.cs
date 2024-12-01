using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Perfect numbers between 1 and 10,000:");
        for (int i = 1; i <= 10000; i++)
        {
            if (IsPerfect(i))
            {
                Console.WriteLine(i);
            }
        }


        CheckPerfectNumber(8128);

    }

    static bool IsPerfect(int number)
    {
        int sum = 0;
        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                sum += i;
            }
        }
        return sum == number;
    }

    static void CheckPerfectNumber(int number)
    {
        if (IsPerfect(number))
        {
            Console.WriteLine($"{number} is a perfect number.");
        }
        else
        {
            Console.WriteLine($"{number} is not a perfect number.");
        }
    }
}