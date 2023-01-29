namespace Calculator.Tests;

public class CalculatorTests
{
  [Test]
  public void Setup_Test()
  {
    Assert.Pass();
  }

  [Test]
  [TestCase(1, 1)]
  public void Add_TwoNumbers_ReturnTotal(int first, int second)
  {
    Calculator calculator = new Calculator();
    int actual = calculator.Add(first, second);
    int expected = first + second;
    Assert.AreEqual(actual, expected);
  }
}