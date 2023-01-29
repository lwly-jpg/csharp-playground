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

    public void Print_ItemName_Price(string item, double price)
    {
        PriceDisplay priceDisplay = new PriceDisplay();
        string actual = priceDisplay.GetPriceLabel(item, price);
        string expected = "The price for item {0:d} is {1:0.00}";
        Assert.That(actual, Is.EqualTo(expected));
    }

  }
}
