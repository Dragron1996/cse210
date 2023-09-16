using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your score?");
        string user_score = Console.ReadLine();
        int score = int.Parse(user_score);
        Console.Write(score);

        string grade = "";
        Console.Write(grade);
        if (score >= 90)
        {
            grade = "A";
            
        }
        else if (score >= 80)
        {
            grade = "B";
        }
        else if (score >= 70)
        {
            grade = "C";
        }
        else if (score >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        Console.WriteLine($"Your grade is: {grade}");

        if (score >= 70)
        {
            Console.WriteLine("You passed.");
        }
        else
        {
            Console.WriteLine("You did not passed");
        }

    }
}