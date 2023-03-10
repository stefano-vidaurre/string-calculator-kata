namespace StringCalculator.Test;

using Console;
using FluentAssertions;

public class StringCalculatorSpecs
{
    [Test]
    public void ShouldReturnZeroWhenInputIsEmpty()
    {
        int result = Program.Add("");
        
        result.Should().Be(0);
    }
    
    [TestCase("1", 1)]
    [TestCase("2", 2)]
    [TestCase("3", 3)]
    public void ShouldReturnParsedNumberForOnlyOneNumber(string number, int expectedResult)
    {
        int result = Program.Add(number);
        
        result.Should().Be(expectedResult);
    }
    
    [TestCase("4,5", 9)]
    [TestCase("6,7", 13)]
    [TestCase("8,9", 17)]
    public void ShouldReturnTheSumWhenInputAreTwoNumbers(string numbers, int expectedResult)
    {
        int result = Program.Add(numbers);
        
        result.Should().Be(expectedResult);
    }

    public void ShouldReturnTheSumWhenInputAreThreeNumbers()
    {
        int result = Program.Add("10,20,30");
        result.Should().Be(60);
    }
}