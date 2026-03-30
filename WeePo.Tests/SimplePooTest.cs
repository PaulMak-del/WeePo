using JetBrains.Annotations;
using Xunit;

namespace WeePo.Tests;

[TestSubject(typeof(SimplePoo))]
public class SimplePooTest
{

    [Fact]
    public void SimpleTest()
    {
        SimplePoo instance = new();
        int result = instance.SumOfTwo(5, 4);
        
        Assert.Equal(9, result);
    }
    
    [Fact]
    public void SecondSimpleTest()
    {
        SimplePoo instance = new();
        int result = instance.SumOfThree(5, 4, 3);
        
        Assert.Equal(12, result);
    }
}