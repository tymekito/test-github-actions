using ConsoleApp1;
using Xunit;
using FluentAssertions;

namespace SimpleUnitTests;

public class TestMathFunctions
{
    [Fact]
    public void Test_AddNumbers()
    {
        var result = MathFunctions.AddNumbers(2, 2);

        result.Should().Be(5);
    }

}