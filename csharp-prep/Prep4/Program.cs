using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> list = new List<int>();
        int num = 0;
        int totalSum = 0;

        do
        {
            Console.Write("Enter number: ");
            string numbers = Console.ReadLine();
            num = int.Parse(numbers);
            list.Add(num);

            totalSum = num + totalSum;
        } while (num != 0);

        int count = 0;
        int large = list.Max();

        foreach (int numbers in list)
        {
            count++;
        }

        if (num == 0)
        {
            count--;
        }

        decimal average = totalSum / count;
        string avg = string.Format("{0:F2}", average);

        Console.WriteLine("");
        Console.WriteLine($"List Count: {count}");
        Console.WriteLine($"Sum: {totalSum}");
        Console.WriteLine($"Average: {avg}");
        Console.WriteLine($"Largest Number: {large}");
    }
}