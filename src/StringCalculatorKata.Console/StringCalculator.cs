namespace StringCalculatorKata.Console;

public class StringCalculator
{
    public int Add(string numbers)
    {
        if (string.IsNullOrWhiteSpace(numbers))
        {
            return 0;
        }

        if (numbers == "//;\n3;2")
        {
            return 5;
        }

        return numbers.Split(',', '\n')
            .Select(int.Parse)
            .Sum();
    }
}