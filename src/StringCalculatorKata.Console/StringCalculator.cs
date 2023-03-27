namespace StringCalculatorKata.Console;

public class StringCalculator
{
    public int Add(string numbers)
    {
        if (string.IsNullOrWhiteSpace(numbers))
        {
            return 0;
        }

        return numbers.Split(',', '\n')
            .Select(int.Parse)
            .Sum();
    }
}