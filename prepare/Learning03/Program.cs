using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f = new Fraction();
        Console.WriteLine($"Numerator: {f.GetNumerator()}, Denominator: {f.GetDenominator}");
    }
}