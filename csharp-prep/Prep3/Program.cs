using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Random randomGenerator = new Random();
        int number = randomGenerator.Next (1,11);

        int guess = -1;

        while (guess != number)
        {
            Console.Write("What is your guess?");
            guess = int.Parse(Console.ReadLine());

            if (guess < number)
            {
                Console.WriteLine("guess higher");
            }
            else if (guess > number)
            {
                Console.WriteLine("guess lower");
            }
            else
            {
                Console.WriteLine("correct");
            }
        }

    }
}