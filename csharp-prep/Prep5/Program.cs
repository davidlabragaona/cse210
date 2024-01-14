using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep5 World!");
        string name = string.Empty;
        int number = 0, squared = 0;

        DisplayWelcome();
        name = PromptUserName();
        number = PromptUserNumber();
        squared = SquareNumber(number);
        DisplayResult(name, squared);
    }

    static void DisplayWelcome() {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName() {
        string uname = string.Empty;
        Console.Write("Please enter your name: ");
        uname = Console.ReadLine();
        return uname;
    }

    static int PromptUserNumber() {
        string number = string.Empty;
        int iNumber = 0;
        Console.Write("Please enter your favorite number: ");
        number = Console.ReadLine();
        iNumber = int.Parse(number);
        return iNumber;
    }

    static int SquareNumber(int number) {
        return number * number;
    }

    static void DisplayResult(string username, int squaredNumber) {
        Console.WriteLine($"{username}, the square of your number is {squaredNumber}");
    }
    
}