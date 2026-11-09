namespace TakeTenMinutesWalk.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.That("Hallo", Is.EqualTo("Hallo"), "Because matching string");
    }
}

