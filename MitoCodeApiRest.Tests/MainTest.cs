using MitoCodeApiRest.Entidades;
using Moq;

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