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
        char[] separator = {',', '\n'};
        
        if (string.IsNullOrEmpty(numbers))
        {
            return 0;
        }

        if (numbers.StartsWith("//"))
        {
            separator = new char[]{ numbers[2] };
            numbers = numbers[4..];
        }

        string[] numberList = numbers.Split(separator);
        int[] parsedNumbers = numberList.Select(int.Parse).ToArray();

        if (parsedNumbers.Any(int.IsNegative))
        {
            throw new ArgumentException();
        }
        
        return parsedNumbers.Sum();
    }
}

