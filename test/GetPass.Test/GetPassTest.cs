using Xunit;

namespace GetPass.Test
{
    public partial class GetPassTest
    {
        [Theory]
        [InlineData(new char[0], "", "")]
        [InlineData(new[] { 'a' }, "*", "a")]
        [InlineData(new[] { 'a', 'b' }, "**", "ab")]
        [InlineData(new[] { 'a', '\b', 'b' }, "*\b \b*", "b")]
        [InlineData(new[] { 'a', '\b', '\b', 'b' }, "*\b \b*", "b")]
        [InlineData(new[] { '\0' }, "", "")]
        [InlineData(new[] { ';' }, "*", ";")]
        [InlineData(new[] { '€' }, "*", "€")]
        public void ConsoleTest(char[] characters, string expectedOutput, string expectedPassword)
        {
            // Arrange
            var console = new FakeConsole(characters);
            Console.FakeConsole = console;

            // Act
            var password = ConsolePasswordReader.Read();

            // Assert
            Assert.Equal(expectedPassword, password);
            Assert.Equal($"Password: {expectedOutput}\n", console.Output);
        }
    }
}
