using Xunit;

public class MyAppTests
{
    [Fact]
    public void Test1()
    {
        // Arrange
        var expected = 5;
        var actual = 2 + 3;

        // Act & Assert
        Assert.Equal(expected, actual);
    }
}
