namespace ShoppingList
{
  public class ShoppingList
  {
    public List<ShoppingItem> items = new List<ShoppingItem>();

    public void Add(ShoppingItem item)
    {
      items.Add(item);
    }

    public List<ShoppingItem> Get()
    {
      return items;
    }
  }

  public class ShoppingItem
  {
    public ShoppingItem(string name, double price)
    {
      string itemName = name;
      double itemPrice = price;
    }
  }
}