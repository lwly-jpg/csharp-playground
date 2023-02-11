using System;

namespace Game
{
  internal class Program
  {
    static void Main(string[] args)
    {
      WordChooser chooser = new WordChooser();
      Game game = new Game(chooser);
      Console.WriteLine("Welcome! Today the word to guess is:");
      Console.WriteLine(game.GetWordToGuess());

    }
  }
}