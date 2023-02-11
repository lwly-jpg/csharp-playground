using System;
using System.Text;
using System.Linq;

namespace Game
{

  public class Game
  {
    public string solution;
    public int attempts;
    public List<char> guessedLetters;
    public bool win;
    public WordChooser chooser = new WordChooser();

    public Game(WordChooser chooser)
    {
      solution = chooser.GetRandomWordFromDictionary();
      attempts = 10;
      guessedLetters = new List<char>{};
      win = false;
    }
    public string GetWordToGuess()
    {
      StringBuilder builder = new StringBuilder();
      for (int i = 0; i < solution.Length; i++)
      {
        char currentLetter = solution[i];
        if (i == 0)
        {
          builder.Append(currentLetter);
        }
        else if (guessedLetters.Contains(currentLetter)) {
          builder.Append(currentLetter);
        }
        else
        {
          builder.Append("_");
        }
      }
      
      string attemptedSolution = builder.ToString();
      
      if (!attemptedSolution.Contains("_"))
      {
        win = true;
      }

      return attemptedSolution;
    }

    public int GetRemainingAttempts()
    {
      return attempts;
    }

    public bool CheckLetter(char letter)
    {
      letter = Char.ToUpper(letter);
      if (solution.Contains(letter))
      {
        guessedLetters.Add(letter);
        return true;
      } else {
        attempts -= 1;
        return false;
      }
    }
  }
}

public class WordChooser
{
  public readonly string[] DICTIONARY = { "BAKERS", "SWEETS", "CODING", "LONDON", "TRAVEL" };

  public virtual string GetRandomWordFromDictionary()
  {
    Random random = new Random();
    int randomNumber = random.Next(0, DICTIONARY.Length);
    return DICTIONARY[randomNumber];
  }
}