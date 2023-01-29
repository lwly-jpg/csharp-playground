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
      double result = 2.5 + 2.5;
      Console.WriteLine("The result is {0:0.000000}", result);
    }
  }

  class Clock {
    public void DisplayTime()
    {
      DateTime dt = DateTime.Now;
      String time = dt.ToString("HH:mm");
      Console.WriteLine("The current time is {0:t}", time);
    }
  }
}