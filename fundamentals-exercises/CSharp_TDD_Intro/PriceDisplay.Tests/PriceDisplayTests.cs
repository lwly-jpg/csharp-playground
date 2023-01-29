namespace PriceDisplay.Tests
{
  public class PriceDisplayTests
  {

    [Test]
    public void Setup_Test()
    {
      Assert.Pass();
    }

    [Test]
    [TestCase("kettle", 12.00)]
    [TestCase("fridge", 350.60)]
    [TestCase("chocolate bar", 1.00)]
    [TestCase("car", 2999.99)]
    [TestCase("cling film", 123.00)]

    public void Print_ItemName_Price(string item, double price)
    {
        PriceDisplay priceDisplay = new PriceDisplay();
        string actual = priceDisplay.GetPriceLabel(item, price);
        string expected = $"The price for item {item} is {price:0.00}";
        Assert.That(actual, Is.EqualTo(expected));
    }

  }
}
