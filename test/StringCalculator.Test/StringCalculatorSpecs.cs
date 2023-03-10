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
    
    // TODO: Comprobar casos con dos numeros: "4,5", "6,7", "8,9"

    [Test]
    public void ShouldReturnNineWhenInputIsFourAndFive()
    {
        int result = Program.Add("4,5");
        
        result.Should().Be(9);
    }
    
    [Test]
    public void ShouldReturnThirtyWhenInputIsSixAndSeven()
    {
        int result = Program.Add("6,7");
        
        result.Should().Be(13);
    }
}