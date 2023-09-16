using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        List<int> numbers = new List<int>();
        int number = -1;
        while (number != 0)
        {
            Console.Write("add a number (type 0 to stop)");
            string input = Console.ReadLine();
            number = int.Parse(input);
            if (number != 0)
            {
                numbers.Add(number);
            }
            else if (number == 0)
            {
                int sum = 0;
                foreach (int part in numbers)
                {
                    sum += part;
                }

                Console.WriteLine($"The sum is {sum}");

                float average = ((float)sum) / numbers.Count;
                Console.WriteLine($"The average is {average}");

                int max = numbers[0];

                foreach (int part in numbers)
                {
                    if (number > max)
                    {
                        max = number;
                    }
                }

                Console.WriteLine($"the max is {max}");
            }
        }
    }
}