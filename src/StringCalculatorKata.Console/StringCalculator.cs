namespace StringCalculatorKata.Console;

public class StringCalculator
{
    public int Add(string numbers)
    {
        if (numbers == "1")
        {
            return 1;
        }

        if (numbers == "2")
        {
            return 2;
        }
        
        return 0;
    }
}