using MitoCodeApiRest.Entidades;
using Moq;

namespace MitoCodeApiRest.Tests;

public class MainTest
{
    [Theory]
    [InlineData(5,6,11)]
    [InlineData(5,5,10)]
    [InlineData(5,7,12)]
    [InlineData(1,1,2)]
    [InlineData(3,5,8)]
    public void SumaTest(int a, int b, int expected)
    {
        var actual = a + b;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public async Task PersonaRepositoryTest()
    {
        var repositoryConfig = new Mock<IPersonaRepository>();

        repositoryConfig
            .Setup(x => x.ListAsync())
            .ReturnsAsync(new List<Persona>());

        var repository = repositoryConfig.Object;

        var expected = 0;

        var list = await repository.ListAsync();
        var actual = list.Count;

        Assert.Equal(expected, actual);
    }
}