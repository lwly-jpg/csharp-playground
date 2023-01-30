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
        int actual = toDo.tasks.Count;
        int expected = 0;
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    [TestCase("Go to the gym")]

    public void Add_New_Task(string task)
    {
        ToDo toDo = new ToDo();
        toDo.Add(task);
        int actual = toDo.tasks.Count;
        int expected = 1;
        Assert.That(actual, Is.EqualTo(expected));
    }

}