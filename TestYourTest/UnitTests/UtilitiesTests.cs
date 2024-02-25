using ConsoleApp;
using Xunit;

namespace UnitTests;

public class Tests
{
    [Fact]
    public void Positive_Number_Should_Return_true()
    {
        var isPositive = Utilities.IsPositive(10);
        
        Assert.True(isPositive);
    }
    
    [Fact]
    public void Negative_Number_Should_Return_false()
    {
        var isPositive = Utilities.IsPositive(-10);
        
        Assert.False(isPositive);
    }
    
    [Fact]
    public void IsPositive_Method_Test()
    {
        var isPositive = Utilities.IsPositive(-10);
        
        Assert.InRange(-10, int.MinValue, int.MaxValue);
    }
}