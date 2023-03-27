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
    
    private static IEnumerable<int> ParseNumbers(string numbers, char[] separators)
    {
        return numbers.Split(separators)
            .Where(s => !string.IsNullOrEmpty(s))
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
        int endAt = numbers.IndexOf('\n');
        string separatorsString = numbers[2..endAt];
        char[] separatorsList = separatorsString
            .Split('[')
            .Where(s => !string.IsNullOrEmpty(s))
            .Select(s => s[0]).ToArray();
        return separators.Concat(separatorsList).ToArray();
    }
    
    private static bool HasCustomSeparator(string numbers)
    {
        return numbers.StartsWith("//");
    }
}