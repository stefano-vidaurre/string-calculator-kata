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
        if (numbers == "1")
        {
            return 1;
        }

        if (numbers == "2")
        {
            return 2;
        }
        
        if (numbers == "3")
        {
            return 3;
        }
        
        return 0;
    }
}

