using System;

namespace CSharp.Intro
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      new Calculator().Calculate();
      new Clock().DisplayTime();
    }
  }
  class Calculator
  {
    public void Calculate()
    {
      int result = 2 + 3;
      Console.WriteLine("The result is {0:d}", result);
    }
  }

  class Clock {
    public void DisplayTime()
    {
      DateTime dt = DateTime.Now;
      String time = dt.ToString("HH:mm");
      Console.WriteLine("The current time is {0:d}", time);
    }
  }
}