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
}