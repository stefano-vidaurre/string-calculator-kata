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
    public void ReturnFourWhenInputIsThreeCommaOne()
    {
        int result = _stringCalculator.Add("3,1");
        Assert.That(result, Is.EqualTo(4));
    }
    
    [Test]
    public void ReturnFiveWhenInputIsThreeCommaTwo()
    {
        int result = _stringCalculator.Add("3,2");
        Assert.That(result, Is.EqualTo(5));
    }

    [TestCase("2,3,4", 9)]
    [TestCase("2,3,4,5", 14)]
    [TestCase("2,3,4,5,6", 20)]
    public void ReturnTheSumOfNumbersWhenInputIsAComaSeparatedValuesList(string numbers, int resultExpected)
    {
        int result = _stringCalculator.Add(numbers);
        Assert.That(result, Is.EqualTo(resultExpected));
    }
    
    [Test]
    public void SumTheValuesWhenInputContainsCr()
    {
        int result = _stringCalculator.Add("3,2\n3");
        Assert.That(result, Is.EqualTo(8));
    }

    [Test]
    public void SumTheNumbersThreeAndTwoWhenInputContainsASemicolonSeparator()
    {
        int result = _stringCalculator.Add("//;\n3;2");
        Assert.That(result, Is.EqualTo(5));
    }

    [Test]
    public void ReportAErrorWhenInputContainsANegativeNumber()
    {
        TestDelegate action = () => _stringCalculator.Add("3,-2");
        Assert.Throws<ArgumentException>(action, "negatives not allowed: -2");
    }

    [Test]
    public void IgnoreTheNumbersGreaterThan1000()
    {
        int result = _stringCalculator.Add("2,1001");
        Assert.That(result, Is.EqualTo(2));
    }

    [Test]
    public void AcceptCustomSeparatorsOfAnySize()
    {
        int result = _stringCalculator.Add("//[***]\n1***2***3");
        Assert.That(result, Is.EqualTo(6));
    }
}