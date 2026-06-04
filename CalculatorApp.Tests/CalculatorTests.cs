using Xunit;
using CalculatorApp

namespace CalculatorApp.Tests;

public class CalculatorTests  
{
    [Fact]
    public void ShouldAddTwoNumbers()
    {
        var calculator = new Calculator();
        double result = calculator.Add(1, 2);
        Assert.Equal(3, result);
    }
}
