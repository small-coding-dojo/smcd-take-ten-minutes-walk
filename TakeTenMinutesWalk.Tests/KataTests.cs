namespace TakeTenMinutesWalk.Tests;

public class KataTests
{
    [Test]
    public void EmptyWalk_IsFalse()
    {
        var actual = Kata.IsValidWalk([]);
        Assert.That(actual, Is.False, "Because empty array is invalid");
    }

    [Test]
    public void FiveNorthFiveSouth_IsTrue()
    {
        var actual = Kata.IsValidWalk(["n", "n", "n", "n", "n", "s", "s", "s", "s", "s" ]);
        Assert.That(actual, Is.True, "Because we walk forth and back in 10 steps");
    }

    [Test]
    public void FourNorthSixSouth_IsFalse()
    {
        var actual = Kata.IsValidWalk(["n", "n", "n", "n", "s", "s", "s", "s", "s", "s" ]);
        Assert.That(actual, Is.False, "Because we walk north x4 and south x6 steps");
    }

    [Test]
    public void FourWestSixEast_IsFalse()
    {
        var actual = Kata.IsValidWalk(["w", "w", "w", "w", "e", "e", "e", "e", "e", "e" ]);
        Assert.That(actual, Is.False, "Because we walk west x4 and east x6 steps");
    }
}

public class Kata
{
    public static bool IsValidWalk(string[] directions)
    {
        var is10minWalk = directions.Length == 10;
        var northSouthDifference = directions.Count("n") - directions.Count("s");
        var eastWestDifference = directions.Count("e") - directions.Count("w");
        return is10minWalk && northSouthDifference == 0 && eastWestDifference == 0;
    }
}
