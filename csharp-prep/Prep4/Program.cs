using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<int> listNum = new List<int>();

        int num = -1;
        Console.WriteLine(" Enter a list of numbers, type 0 when finished");

        while (num != 0)
        {
            Console.WriteLine("Enter number: ");
            num = int.Parse(Console.ReadLine());

            if (num != 0)
            {
                listNum.Add(num); 
            }

        }

        int count = 0;
        int sum = 0;

        foreach (int x in listNum)
        {
            Console.WriteLine(x);
            count += 1;
            sum += x;
        }

        int maxNum = listNum.Max();

        float avg = ((float)sum)/count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"Largest number is: {maxNum}");

    }
}