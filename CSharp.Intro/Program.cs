using System;

namespace CSharp.Intro
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      new Calculator().Calculate();
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
}