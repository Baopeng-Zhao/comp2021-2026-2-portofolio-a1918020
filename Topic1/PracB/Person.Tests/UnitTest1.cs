public class UnitTest1
{
    [Fact]
    public void FullName_ReturnsExpectedFormat()
    {
        Person person = new Person("Ian", "Zhao", 21);

        string result = person.FullName();

        Assert.Equal("Zhao Ian", result);
    }

    [Fact]
    public void IsAdult_ReturnsTrue_WhenAge18OrMore()
    {
        Person person = new Person("Ian", "Wang", 21);

        bool result = person.IsAdult();

        Assert.True(result);
    }
}