using Xunit; 

public class ProgramTests
{
    [Fact] 
    public void Greet_ReturnsExpectedString()
    {
        // Act
        var result = Program.FavoriteColor();

        // Assert
        Assert.Equal("Привет, Git!", result);
    }
}