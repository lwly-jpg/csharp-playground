namespace Game.Tests;
using NSubstitute;

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
    WordChooser mockChooser = Substitute.For<WordChooser>();
    mockChooser.GetRandomWordFromDictionary().Returns("BAKERS");
    Game game = new Game(mockChooser);
    Assert.AreEqual("B_____", game.GetWordToGuess());
  }

  [Test]
  public void Game_GetReamingAttempts_ReturnsAttempts()
  {
    WordChooser mockChooser = Substitute.For<WordChooser>();
    Game game = new Game(mockChooser);
    Assert.AreEqual(10, game.GetRemainingAttempts());
  }

  [Test]
  public void WordChooser_Constructs_With_Dictionary()
  {
    WordChooser chooser = new WordChooser();
    Assert.NotNull(chooser.DICTIONARY);
  }

  [Test]
  [TestCase('B')]
  public void GuessLetter_Returns_True_When_Letter_Present(char a)
  {
    WordChooser mockChooser = Substitute.For<WordChooser>();
    mockChooser.GetRandomWordFromDictionary().Returns("BAKERS");
    Game game = new Game(mockChooser);
    Assert.AreEqual(true, game.CheckLetter(a));
  }

  [Test]
  [TestCase('X')]
  public void GuessLetter_Returns_False_When_Letter_Not_Present(char a)
  {
    WordChooser mockChooser = Substitute.For<WordChooser>();
    mockChooser.GetRandomWordFromDictionary().Returns("BAKERS");
    Game game = new Game(mockChooser);
    Assert.That(game.CheckLetter(a), Is.EqualTo(false));
  }
}