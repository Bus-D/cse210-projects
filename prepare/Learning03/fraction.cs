using System.Diagnostics;
using System.Runtime.CompilerServices;

public class Fraction
{
    private int _top;
    private int _bottom;

    private void MakeFraction()
    {
        _top = 1;
        _bottom = 1;

        Console.WriteLine($"{_top}/{_bottom}");
    }

    private void MakeFraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;

        Console.WriteLine($"{wholeNumber}/{_bottom}");
    }

    private void MakeFraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;

        Console.WriteLine($"{top}/{bottom}");
    }

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    private int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue()
    {
        // Looked up syntax for rounding decimals
        return Math.Round((double)_top / (double)_bottom, 2);
    }
}