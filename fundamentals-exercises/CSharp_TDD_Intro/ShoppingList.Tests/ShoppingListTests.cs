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
    public void Add_Items_To_ShoppingList()
    {
        ShoppingList list = new ShoppingList();
        list.Add(new ShoppingItem("rice", 1.99));
        list.Add(new ShoppingItem("avocados", 1.50));
        Assert.That(list.items.Count, Is.EqualTo(2));
    }

    [Test]    
    public void Get_Items_In_ShoppingList()
    {
        ShoppingList list = new ShoppingList();
        ShoppingItem rice = new ShoppingItem("rice", 1.99);
        ShoppingItem avocado = new ShoppingItem("avocado", 1.50);
        list.Add(rice);
        list.Add(avocado);
        List<ShoppingItem> expected = new List<ShoppingItem>{rice, avocado};
        Assert.That(list.Get(), Is.EqualTo(expected));

    }
}