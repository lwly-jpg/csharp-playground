using System;
using System.Text;

namespace Game
{
  
  public class Game
  {
    private string solution;
    private int attempts;

    public Game(string word)
    {
      solution = word;
      attempts = 10;
    }
    public string GetWordToGuess()
    {
      StringBuilder builder = new StringBuilder();
      for (int i = 0; i < solution.Length; i++) {
        char currentLetter = solution[0];
        if (i == 0) {
          builder.Append(currentLetter);
        } else {
          builder.Append("_");
        }
      }
      return builder.ToString();
    }

    public int GetRemainingAttempts()
    {
      return attempts;
    }
  }
}