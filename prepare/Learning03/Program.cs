using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new Fraction();

        fraction.SetTop(1);
        fraction.SetBottom(1);

        Console.WriteLine($"{fraction.GetFractionString()}");
        Console.WriteLine($"{fraction.GetDecimalValue()}");

        fraction.SetTop(5);
        fraction.SetBottom(1);

        Console.WriteLine($"{fraction.GetFractionString()}");
        Console.WriteLine($"{fraction.GetDecimalValue()}");

        fraction.SetTop(3);
        fraction.SetBottom(4);

        Console.WriteLine($"{fraction.GetFractionString()}");
        Console.WriteLine($"{fraction.GetDecimalValue()}");

        fraction.SetTop(1);
        fraction.SetBottom(3);

        Console.WriteLine($"{fraction.GetFractionString()}");
        Console.WriteLine($"{fraction.GetDecimalValue()}");
    }
}