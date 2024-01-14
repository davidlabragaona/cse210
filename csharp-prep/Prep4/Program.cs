using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        int number, count, sum, largest, smallest;
        float avg;
        List<int> list = new List<int>();

        //ask the customer for a series of numbers:
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");


        largest = 0;
        number = -1;
        sum = 0;
        avg = 0.0f;
        smallest = 99999;

        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
                list.Add(number);
            sum += number;
            if (number > largest)
                largest = number;
            if (number > 0 && number < smallest)
                smallest = number;
        }
        Console.WriteLine($"The sum is: {sum}");
        if (list.Count > 0)
            avg = (float) sum / list.Count;
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallest}");
        Console.WriteLine("The sorted list is:");
        list.Sort();
        foreach (int element in list) {
            Console.WriteLine(element);
        }
    }
}