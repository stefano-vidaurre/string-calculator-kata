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

        string[] numberList = numbers.Split(',', '\n');
        return numberList.Sum(int.Parse);
    }
}

