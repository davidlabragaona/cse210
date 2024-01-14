using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep2 World!");

        //Core requirements
        string grade, letter, sign;
        int igrade, remainder;

        Console.Write("Enter your grade percentage: ");
        grade = Console.ReadLine();

        igrade = int.Parse(grade);

        if (igrade >= 90)
            letter = "A";
        else if (igrade >= 80)
            letter = "B";
        else if (igrade >= 70)
            letter = "C";
        else if (igrade >= 60)
            letter = "D";
        else
            letter = "F";

        remainder = igrade % 10;
        sign = "";
        if (remainder >= 7) {
            if (letter != "A")
                sign = "+";
        }
        else if (remainder < 3)
            if (letter != "F")
                sign = "-";

        //We print if the student passed.
        Console.WriteLine($"Your grade is: {letter}{sign}");
        if (igrade >= 70)
            Console.WriteLine("Congratulations. You have passed!");
        else
            Console.WriteLine("Unfortunately you didn't pass. Please try again");

    }
}