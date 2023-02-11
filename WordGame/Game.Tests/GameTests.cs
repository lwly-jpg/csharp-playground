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
    Assert.That(game.GetWordToGuess(), Is.EqualTo("B_____"));
  }

  [Test]
  public void Game_GetReamingAttempts_ReturnsAttempts()
  {
    WordChooser mockChooser = Substitute.For<WordChooser>();
    Game game = new Game(mockChooser);
    Assert.That(game.GetRemainingAttempts(), Is.EqualTo(10));
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
    Assert.That(game.CheckLetter(a), Is.EqualTo(true));
    Assert.That(game.guessedLetters[0], Is.EqualTo('B'));
  }

  [Test]
  [TestCase('X')]
  public void GuessLetter_Returns_False_When_Letter_Not_Present(char a)
  {
    WordChooser mockChooser = Substitute.For<WordChooser>();
    mockChooser.GetRandomWordFromDictionary().Returns("BAKERS");
    Game game = new Game(mockChooser);
    Assert.That(game.CheckLetter(a), Is.EqualTo(false));
    Assert.That(game.GetRemainingAttempts(), Is.EqualTo(9));
  }
}