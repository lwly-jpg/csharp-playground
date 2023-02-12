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
    Assert.That(actual, Is.EqualTo(expected));
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
    Assert.That(actual, Is.EqualTo(expected));
  }

  [Test]
  [TestCase(5)]
  [TestCase(20)]
  [TestCase(55)]
  [TestCase(95)]
  [TestCase(880)]

  public void For_NumbersDivisibleByFive_ReturnsBuzz(int x)
  {
    FizzBuzz fizzBuzz = new FizzBuzz();
    string actual = fizzBuzz.For(x);
    string expected = "Buzz";
    Assert.That(actual, Is.EqualTo(expected));
  }

  [Test]
  [TestCase(15)]
  [TestCase(60)]
  [TestCase(150)]
  [TestCase(330)]
  [TestCase(990)]

  public void For_NumbersDivisibleByThreeAndFive_ReturnsFizzBuzz(int x)
  {
    FizzBuzz fizzBuzz = new FizzBuzz();
    string actual = fizzBuzz.For(x);
    string expected = "FizzBuzz";
    Assert.That(actual, Is.EqualTo(expected));
  }
  
}