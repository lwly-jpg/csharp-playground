namespace Calculator.Tests
{
  public class CalculatorTests
  {

    [Test]
    public void Setup_Test() {
      Assert.Pass();
    }

    [Test]
    [TestCase(1, 1)]
    [TestCase(1, 2)]
    [TestCase(2, 3)]
    [TestCase(3, 5)]
    [TestCase(8, 12)]
 
    public void Add_TwoNumbers_ReturnTotal(int first, int second)
    {
      Calculator calculator = new Calculator();
      int actual = calculator.Add(first, second);
      int expected = first + second;
      Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    [TestCase(1, 1)]
    [TestCase(1, 2)]
    [TestCase(2, 3)]
    [TestCase(3, 5)]
    [TestCase(8, 10)]

    public void Multiply_TwoNumbers_ReturnProduct(int first, int second)
    {
      Calculator calculator = new Calculator();
      int actual = calculator.Multiply(first, second);
      int expected = first * second;
      Assert.That(actual, Is.EqualTo(expected));
    }


  }
}