namespace MitoCodeApiRest.Tests;

public class MainTest
{
    [Fact]
    public void SumaTest()
    {
        var a = 5;
        var b = 6;

        var expected = 11;

        var actual = a + b;

        Assert.Equal(expected, actual);
    }
}