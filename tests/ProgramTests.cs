using NUnit.Framework;

[TestFixture]
public class ProgramTests
{
    [Test]
    public void Greet_ReturnsCorrectMessage()
    {
        // act
        var result = typeof(Program)
            .GetMethod("Greet", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static)
            .Invoke(null, null);

        // assert
        Assert.AreEqual("Привет, Git!", result);
    }
}