﻿using System;

namespace CSharp.Intro
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      new Calculator().Calculate();
      new Clock().DisplayTime();
      new PriceDisplay().display();
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
      string time = dt.ToString("HH:mm");
      Console.WriteLine("The current time is {0:t}", time);
    }
  }

  class PriceDisplay {
    public void display() {
      string item = "Coffee machine";
      double price = 11.99;
      Console.WriteLine("The price of a {0:d} is {1:0.00}", item, price);
    }
  }
}