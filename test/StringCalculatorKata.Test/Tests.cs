using StringCalculatorKata.Console;

namespace StringCalculatorKata.Test;

public class Tests
{
    private StringCalculator _stringCalculator;

    [SetUp]
    public void SetUp()
    {
        _stringCalculator = new StringCalculator();
    }

    [Test]
    public void ReturnZeroWhenInputIsEmpty()
    {
        int result = _stringCalculator.Add("");
        Assert.That(result, Is.Zero);
    }

    [Test]
    public void ReturnOneWhenInputIsOne()
    {
        int result = _stringCalculator.Add("1");
        Assert.That(result, Is.EqualTo(1));
    }

    [Test]
    public void ReturnTwoWhenInputIsTwo()
    {
        int result = _stringCalculator.Add("2");
        Assert.That(result, Is.EqualTo(2));
    }
    
    [Test]
    public void ReturnFourWhenInputIsThreeComaOne()
    {
        int result = _stringCalculator.Add("3,1");
        Assert.That(result, Is.EqualTo(4));
    }
    
    [Test]
    public void ReturnFiveWhenInputIsThreeComaTwo()
    {
        int result = _stringCalculator.Add("3,2");
        Assert.That(result, Is.EqualTo(5));
    }
}