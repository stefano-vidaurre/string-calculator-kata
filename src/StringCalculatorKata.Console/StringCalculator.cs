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
        
        if (numbers.StartsWith("//"))
        {
            separators = separators.Append(numbers[2]).ToArray();
            numbers = numbers[4..];
        }

        return numbers.Split(separators)
            .Select(int.Parse)
            .Sum();
    }
}