using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Running activity1 = new Running("10-26-2025", 20, 5.0, "Running");
        Console.WriteLine(activity1.GetSummary());

        Swimming activity2 = new Swimming("10-26-2025", 30, "Swimming", 30);
        Console.WriteLine(activity2.GetSummary());

        Cycling activity3 = new Cycling("10-26-2025", 120, "Cycling", 25.0, 20);
        Console.WriteLine(activity3.GetSummary());
    }
}