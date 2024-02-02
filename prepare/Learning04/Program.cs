using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("David Labra Gaona", "Algebra");
        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine();

        MathAssignment mathAssignment = new MathAssignment("David Labra Gaona", "Programming", "7.3", "8-19");
        Console.WriteLine($"{mathAssignment.GetSummary()}\n{mathAssignment.GetHomeworkList()}");
        Console.WriteLine();

        WritingAssignment writingAssignment = new WritingAssignment("David Labra Gaona", "European History", "The Causes of World War II");
        Console.WriteLine($"{writingAssignment.GetSummary()}\n{writingAssignment.GetWritingInformation()}");
    }
}