using System.Text;

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
        int[] negativeNumbers = parsedNumbers.Where(int.IsNegative).ToArray();
        
        if (negativeNumbers.Any())
        {
            StringBuilder builder = new StringBuilder();
            foreach (int negativeNumber in negativeNumbers)
            {
                builder.Append($" {negativeNumber}");
            }
            throw new ArgumentException($"negatives not allowed:{builder}");
        }
        
        return parsedNumbers.Sum();
    }
}

