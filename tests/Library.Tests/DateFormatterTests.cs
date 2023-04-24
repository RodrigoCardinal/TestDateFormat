using NUnit.Framework;
using TestDateFormat;

namespace Library.Tests;

public class DateFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        string input = "14/09/2003";
        string expected = "2003-09-14";

        string actual = DateFormatter.ChangeFormat(input);

        Assert.That(actual, Is.EqualTo(expected));
    }

     [Test]
    public void TestWrongDay()
    {
        string input = "14/09/20033";
        string expected = "";

        string actual = DateFormatter.ChangeFormat(input);

        Assert.That(actual, Is.EqualTo(expected));
    }
     [Test]
    public void TestBlankDate()
    {
        string input = "";
        string expected = "";

        string actual = DateFormatter.ChangeFormat(input);

        Assert.That(actual, Is.EqualTo(expected));
    }
     [Test]
    public void TestWrongCharacter()
    {
        string input = "14/12;Ab";
        string expected = "";

        string actual = DateFormatter.ChangeFormat(input);

        Assert.That(actual, Is.EqualTo(expected));
    }

}