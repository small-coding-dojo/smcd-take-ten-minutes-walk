using System.Reflection;
using System.Reflection.Metadata.Ecma335;
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

    private static void DoTest(int input, int expected)
    {
        int actual = Kata.CountBits(input);
        Assert.That(actual, Is.EqualTo(expected), "for n = " + input);
    }

    [Test, Order(1)]
    public void FixedTests()
    {
        DoTest(0, 0);
        DoTest(4, 1);
        DoTest(7, 3);
        DoTest(12525589, 11);
        DoTest(3811, 8);
        DoTest(392902058, 17);
        DoTest(1044, 3);
        DoTest(10030245, 10);
        DoTest(89, 4);
        DoTest(674259, 10);
        DoTest(Int32.MaxValue, 31);
    }
}

public class Kata
{
    public static int CountBits(int number)
    {
        return number.ToString("B").Count('1');
    }
}