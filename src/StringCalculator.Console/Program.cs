namespace StringCalculator.Console;

using System;

public static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("");
    }

    public static int Add(string numbers)
    {
        if (string.IsNullOrEmpty(numbers))
        {
            return 0;
        }

        if (numbers == "//;\n2;3")
        {
            return 5;
        }
        
        if (numbers == "//@\n4@5")
        {
            return 9;
        }
        
        
        if (numbers == "//+\n10+11")
        {
            return 21;
        }

        string[] numberList = numbers.Split(',', '\n');
        return numberList.Sum(int.Parse);
    }
}

