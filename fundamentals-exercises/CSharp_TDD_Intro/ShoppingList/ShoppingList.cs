namespace ShoppingList
{
  public class ShoppingList
  {
    public List<string> items = new List<string>();

    public void Add(string item)
    {
      items.Add(item);
    }
  }
}