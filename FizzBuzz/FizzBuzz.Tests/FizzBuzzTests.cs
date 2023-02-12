namespace FizzBuzz.Tests;

public class FizzBuzzTests
{
    [Test]
    public void Setup_Tests()
    {
        Assert.Pass();
    }

    [Test]
    [TestCase(1)]
    [TestCase(6)]
    [TestCase(19)]
    [TestCase(37)]
    [TestCase(202)]
    public void For_NumbersNotDivisibleByThreeOrFive_ReturnsNumber(int x)
    {
        FizzBuzz fizzBuzz = new FizzBuzz();
        int actual = fizzBuzz.For(x);
        int expected = x;
        Assert.That(expected, Is.EqualTo(actual));
    }
}