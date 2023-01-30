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

    [Test]
    [TestCase("Go to the gym", "Clean flat", "Learn C#")]

    public void Add_Multiple_Tasks(string a, string b, string c)
    {
        ToDo toDo = new ToDo();
        toDo.Add(a);
        toDo.Add(b);
        toDo.Add(c);
        int actual = toDo.tasks.Count;
        int expected = 3;
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    [TestCase("Go to the gym", "Clean flat", "Learn C#")]

    public void Get_ToDo_List(string a, string b, string c)
    {
        ToDo toDo = new ToDo();
        toDo.Add(a);
        toDo.Add(b);
        toDo.Add(c);
        string actual = toDo.Get();
        string expected = $"{a}, {b}, {c}";
        Assert.That(actual, Is.EqualTo(expected));
    }
    

}