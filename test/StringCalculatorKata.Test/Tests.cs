using StringCalculatorKata.Console;

namespace StringCalculatorKata.Test;

public class Tests
{
    [Test]
    public void ReturnZeroWhenInputIsEmpty()
    {
        StringCalculator stringCalculator = new StringCalculator();
        int result = stringCalculator.Add("");
        Assert.That(result, Is.Zero);
    }

    [Test]
    public void ReturnOneWhenInputIsOne()
    {
        StringCalculator stringCalculator = new StringCalculator();
        int result = stringCalculator.Add("1");
        Assert.That(result, Is.EqualTo(1));
    }
}