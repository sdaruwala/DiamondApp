using DiamondApp.Services;
using Xunit;

public class DiamondGeneratorTests
{
    private readonly DiamondGenerator _generator;

    public DiamondGeneratorTests()
    {
        _generator = new DiamondGenerator();
    }

    [Fact]
    public void GenerateDiamond_WithInvalidCharacter_ShouldThrowException()
    {
        Assert.Throws<ArgumentException>(() => _generator.GenerateDiamond('1'));
    }

    [Fact]
    public void GenerateDiamond_ForA_ShouldReturnCorrectDiamond()
    {
        var expected = new string[] { "A" };
        var result = _generator.GenerateDiamond('A');
        Assert.Equal(expected, result);
    }

    [Fact]
    public void GenerateDiamond_ForB_ShouldReturnCorrectDiamond()
    {
        var expected = new string[]
        {
            " A",
            "B B",
            " A"
        };
        var result = _generator.GenerateDiamond('B');
        Assert.Equal(expected, result);
    }

    [Fact]
    public void GenerateDiamond_ForC_ShouldReturnCorrectDiamond()
    {
        var expected = new string[]
        {
            "  A",
            " B B",
            "C   C",
            " B B",
            "  A"
        };
        var result = _generator.GenerateDiamond('C');
        Assert.Equal(expected, result);
    }
}
