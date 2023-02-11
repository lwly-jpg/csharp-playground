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
}