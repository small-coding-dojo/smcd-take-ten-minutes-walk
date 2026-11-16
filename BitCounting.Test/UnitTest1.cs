using System.Reflection;
using System.Runtime.CompilerServices;

namespace BitCounting.Test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var actual = Kata.CountBits(0);
        Assert.That(actual, Is.EqualTo(0), "because no bits");
    }

    [Test]
    public void Test2()
    {
        var actual = Kata.CountBits(1);
        Assert.That(actual, Is.EqualTo(1), "because 1");
    }

    [Test]
    public void Test3()
    {
        var actual = Kata.CountBits(2);
        Assert.That(actual, Is.EqualTo(1), "because 10");
    }
}

public class Kata
{
    public static int CountBits(int number)
    {
        return number;
    }
}