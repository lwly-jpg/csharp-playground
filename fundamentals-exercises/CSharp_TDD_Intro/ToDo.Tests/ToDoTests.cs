namespace ToDo.Tests;

public class ToDoTests
{
    [Test]
    public void Setup_Test()
    {
        Assert.Pass();
    }

    [Test]

    public void Initialised_Empty_TaskList()
    {
        ToDo toDo = new ToDo();
        int expected = toDo.tasks.Length;
        int actual = 0;
        Assert.That(expected, Is.EqualTo(actual));
    }

}