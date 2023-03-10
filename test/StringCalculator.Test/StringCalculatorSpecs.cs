namespace StringCalculator.Test;

using Console;
using FluentAssertions;

public class StringCalculatorSpecs
{
    // TODO: Comprobar caso vacio
    
    [Test]
    public void ShouldReturnZeroWhenInputIsEmpty()
    {
        int result = Program.Add("");
        
        result.Should().Be(0);
    }
    
    
    // TODO: Comprobar casos con un solo numero: 1, 2, 3
    // TODO: Comprobar casos con dos numeros: "4,5", "6,7", "8,9"
}