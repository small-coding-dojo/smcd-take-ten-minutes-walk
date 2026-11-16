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
        var actual = Kata.IsValidWalk([]);
        Assert.That(actual, Is.EqualTo(false), "Because empty array is invalid");
    }

    [Test]
    public void Test2()
    {
        var actual = Kata.IsValidWalk(["n", "n", "n", "n", "n", "s", "s", "s", "s", "s" ]);
        Assert.That(actual, Is.EqualTo(true), "Because we walk forth and back in 10 steps");
    }

    [Test]
    public void Test3()
    {
        var actual = Kata.IsValidWalk(["n", "n", "n", "n", "s", "s", "s", "s", "s", "s" ]);
        Assert.That(actual, Is.EqualTo(false), "Because we walk north x4 and south x6 steps");
    }

    [Test]
    public void Test4()
    {
        var actual = Kata.IsValidWalk(["w", "w", "w", "w", "e", "e", "e", "e", "e", "e" ]);
        Assert.That(actual, Is.EqualTo(false), "Because we walk west x4 and east x6 steps");
    }
}

public class Kata
{
    public static bool IsValidWalk(string[] directions)
    {
        var is10minWalk = directions.Length == 10;
        var northCoordinate = directions.Count("n") - directions.Count("s");
        var eastCoordinate = directions.Count("e") - directions.Count("w");
        return is10minWalk && northCoordinate == 0 && eastCoordinate == 0;
    }
}
