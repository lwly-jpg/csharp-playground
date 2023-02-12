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
  [TestCase(7)]
  [TestCase(19)]
  [TestCase(37)]
  [TestCase(202)]
  public void For_NumbersNotDivisibleByThreeOrFive_ReturnsNumber(int x)
  {
    FizzBuzz fizzBuzz = new FizzBuzz();
    string actual = fizzBuzz.For(x);
    string expected = x.ToString();
    Assert.That(expected, Is.EqualTo(actual));
  }

  [Test]
  [TestCase(3)]
  [TestCase(9)]
  [TestCase(21)]
  [TestCase(63)]
  [TestCase(309)]
  public void For_NumbersDivisibleByThree_ReturnsFizz(int x)
  {
    FizzBuzz fizzBuzz = new FizzBuzz();
    string actual = fizzBuzz.For(x);
    string expected = "Fizz";
    Assert.That(expected, Is.EqualTo(actual));
  }
}