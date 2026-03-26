using Xunit; 

public class ProgramTests
{
    [Fact] 
    public void Greet_ReturnsExpectedString()
    {
        // Act
        var result = Program.Greet();

        Console.WriteLine("Запуск приложения...");
Assert.Equal("Добро пожаловать в GitPractice!", result);
    }
}