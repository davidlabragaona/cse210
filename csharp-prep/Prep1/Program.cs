using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep1 World!");
        string name, lastname;

        Console.Write("What is your first name? ");
        name = Console.ReadLine();
        Console.Write("What is your last name? ");
        lastname = Console.ReadLine();

        Console.WriteLine($"\nYour name is {lastname}, {name} {lastname}.");
    }
}