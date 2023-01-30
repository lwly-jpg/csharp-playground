namespace Game.Tests;

public class GameTests
{
  [Test]
  public void Setup_Test()
  {
    Assert.Pass();
  }

  [Test]
  public void Game_GetWordToGuess_ReturnsWordToGuess()
  {
    Game game = new Game("BAKERS");
    Assert.AreEqual("B_____", game.GetWordToGuess());

  }
}