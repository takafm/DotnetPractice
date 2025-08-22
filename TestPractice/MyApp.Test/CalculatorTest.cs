using Xunit;
using MyApp;

public class CalculatorTest
{
    [Fact]
    public void Add_Works()
    {
        Assert.Equal(5, Calculator.Add(2, 3));
    }
}
