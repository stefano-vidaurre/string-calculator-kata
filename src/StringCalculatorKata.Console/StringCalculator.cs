namespace StringCalculatorKata.Console;

public class StringCalculator
{
    public int Add(string numbers)
    {
        char[] separators = { ',', '\n' };

        if (string.IsNullOrWhiteSpace(numbers))
        {
            return 0;
        }
        
        if (HasCustomSeparator(numbers))
        {
            return SumWithCustomSeparator(numbers, separators);
        }

        return SumNumbersParsed(ParseNumbers(numbers, separators));
    }

    private static int SumWithCustomSeparator(string numbers, char[] separators)
    {
        separators = GetCustomSeparators(numbers, separators);
        return SumNumbersParsed(ParseNumbers(numbers[4..], separators));
    }

    private static int SumNumbersParsed(IEnumerable<int> numbersParsed)
    {
        return numbersParsed.Sum();
    }

    private static IEnumerable<int> ParseNumbers(string numbers, char[] separators)
    {
        return numbers.Split(separators)
            .Select(int.Parse);
    }

    private static char[] GetCustomSeparators(string numbers, char[] separators)
    {
        separators = separators.Append(numbers[2]).ToArray();
        return separators;
    }

    private static bool HasCustomSeparator(string numbers)
    {
        return numbers.StartsWith("//");
    }
}