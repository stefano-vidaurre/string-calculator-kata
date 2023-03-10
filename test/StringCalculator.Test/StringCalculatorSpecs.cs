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
    [TestCase("10,20,30", 60)]
    [TestCase("10,20,30,40", 100)]
    public void ShouldReturnTheSumWhenInputAreIsOrMoreNumbers(string numbers, int expectedResult)
    {
        int result = Program.Add(numbers);
        
        result.Should().Be(expectedResult);
    }

    [Test]
    public void ShouldReturnTheSumWhenInputIsTwoOrMoreNumbersUsingComaAndCr()
    {
        int result = Program.Add("10,20\n30\n40");
        result.Should().Be(100);
    }
    
    // TODO: Usar separadores diferentes: ';', '@', '+'

    [Test]
    public void ShouldReturnTheSumWhenSeparatorIsSemicolon()
    {
        int result = Program.Add("//;\n2;3");
        result.Should().Be(3);
    }
}