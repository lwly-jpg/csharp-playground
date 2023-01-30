namespace ToDo
{
  public class ToDo
  {
    public List<string> tasks = new List<string>();

    public void Add(string task)
    {
      tasks.Add(task);
    }

    public string Get()
    {
      string allTasks = string.Join( ", ", tasks);
      return allTasks;

    }
  }
}