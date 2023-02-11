namespace ShoppingList.Tests;

public class ShoppingListTests
{
    [Test]
    public void Test_Set_Up()
    {
        Assert.Pass();
    }

    [Test]
    public void Initialised_Empty_ShoppingList()
    {
        ShoppingList list = new ShoppingList();
        Assert.That(list.items.Count, Is.EqualTo(0));
    }

    [Test]
    [TestCase("rice", "avocados", "tomatoes", "red onions", "beef")]
    public void Add_Items_To_ShoppingList(string a, string b, string c, string d, string e)
    {
        ShoppingList list = new ShoppingList();
        list.Add(a);
        list.Add(b);
        list.Add(c);
        list.Add(d);
        list.Add(e);
        Assert.That(list.items.Count, Is.EqualTo(5));
    }
}