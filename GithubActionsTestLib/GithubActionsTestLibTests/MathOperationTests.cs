using GithubActionsTestLib;
using Xunit;

namespace GithubActionsTestLibTests;

public class UnitTest1
{
    [Theory]
    [InlineData(100, 1, 100)]
    [InlineData(50, 5, 250)]
    [InlineData(133, 3, 399)]
    public void AttemptToMultiply(decimal a, decimal b, decimal expected)
    {
        IMathOperation<decimal> multiply = new MultiplyOperation();
        Assert.Equal(expected, multiply.Sum(a, b));
    }
}