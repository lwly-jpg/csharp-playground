﻿using System;

namespace Game
{
  internal class Program
  {
    static void Main(string[] args)
    {
      WordChooser chooser = new WordChooser();
      Game game = new Game(chooser);
      Console.WriteLine("Welcome! Today the word to guess is:");
      while (game.attempts > 0)
      {
        Console.WriteLine(game.GetWordToGuess());
        Console.WriteLine($"Enter one letter to guess ({game.attempts} attemps remaining):");
        char guess = Console.ReadKey(true).KeyChar;
        game.CheckLetter(guess);
      }
    }
  }
}