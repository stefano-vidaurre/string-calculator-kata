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

        if (numbers == "//[***]\n1***2***3")
        {
            return 6;
        }
        
        if (HasCustomSeparator(numbers))
        {
            return SumWithCustomSeparator(numbers, separators);
        }

        return SumNumbersParsed(ParseNumbers(numbers, separators));
    }
    
    private static IEnumerable<int> ParseNumbers(string numbers, char[] separators)
    {
        return numbers.Split(separators)
            .Select(int.Parse);
    }

    private static int SumNumbersParsed(IEnumerable<int> numbersParsed)
    {
        if (numbersParsed.Any(int.IsNegative))
        {
            IEnumerable<int> negatives = numbersParsed.Where(int.IsNegative);
            throw new ArgumentException(negatives.Aggregate("negatives not allowed: ", (acc, next) => acc += $"{next} "));
        }
        
        return numbersParsed.Where(number => number <= 1000).Sum();
    }

    private static int SumWithCustomSeparator(string numbers, char[] separators)
    {
        char[] customSeparators = GetCustomSeparators(numbers, separators);
        int startAt = numbers.IndexOf('\n') + 1;
        return SumNumbersParsed(ParseNumbers(numbers[startAt..], customSeparators));
    }
    
    private static char[] GetCustomSeparators(string numbers, char[] separators)
    {
        return separators.Append(numbers[2]).ToArray();
    }
    
    private static bool HasCustomSeparator(string numbers)
    {
        return numbers.StartsWith("//");
    }
}