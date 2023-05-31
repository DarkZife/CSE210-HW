using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment one = new Assignment("samuel Bennett", "Multiplication");
        Console.WriteLine(one.GetSummary());


        MathAssignment two = new MathAssignment("Roberto Rodiguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(two.GetSummary());
        Console.WriteLine(two.GetHomeworkList());

        WritingAssignment three = new WritingAssignment("Mary Waters", "European History","The Causes of World War II");
        Console.WriteLine(three.GetSummary());
        Console.WriteLine(three.GetWritingInformation());
    }
}