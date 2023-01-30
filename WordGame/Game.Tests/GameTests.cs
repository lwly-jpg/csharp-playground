namespace Game.Tests;

public class GameTests
{
  [Test]
  public void Setup_Test()
  {
    Assert.Pass();
  }

//   [Test]
//   public void Game_GetWordToGuess_ReturnsWordToGuess()
//   {
//     Game game = new Game("BAKERS");
//     Assert.AreEqual("B_____", game.GetWordToGuess());
//   }

  [Test]
  public void Game_GetReamingAttempts_ReturnsAttempts()
  {
    Game game = new Game();
    Assert.AreEqual(10, game.GetRemainingAttempts());
  }

  [Test]
  public void WordChooser_Constructs_With_Dictionary()
  {
    WordChooser chooser = new WordChooser();
    Assert.NotNull(chooser.DICTIONARY);
  }
}