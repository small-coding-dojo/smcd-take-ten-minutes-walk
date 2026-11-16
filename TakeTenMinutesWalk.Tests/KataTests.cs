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

    [Test]
    [Order(1)]
    public void SampleTests()
    {
        Assert.That(Kata.IsValidWalk(["n","s","n","s","n","s","n","s","n","s"]), Is.True, "should return true");
        Assert.That(Kata.IsValidWalk(["w","e","w","e","w","e","w","e","w","e","w","e"]), Is.False, "should return false");
        Assert.That(Kata.IsValidWalk(["w"]), Is.False, "should return false");
        Assert.That(Kata.IsValidWalk(["n","n","n","s","n","s","n","s","n","s"]), Is.False, "should return false");
    }
}