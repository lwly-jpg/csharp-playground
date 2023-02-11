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

  [Test]
  public void Game_GetWordToGuess_ShowsGuessedLetters()
  {
    WordChooser mockChooser = Substitute.For<WordChooser>();
    mockChooser.GetRandomWordFromDictionary().Returns("BAKERS");
    Game game = new Game(mockChooser);
    game.CheckLetter('A');
    Assert.That(game.GetWordToGuess(), Is.EqualTo("BA____"));
  }

  [Test]
  public void Game_GetWordToGuess_ShowsMultipleGuessedLetters()
  {
    WordChooser mockChooser = Substitute.For<WordChooser>();
    mockChooser.GetRandomWordFromDictionary().Returns("BAKERS");
    Game game = new Game(mockChooser);
    game.CheckLetter('a');
    game.CheckLetter('C');
    game.CheckLetter('e');
    game.CheckLetter('G');
    game.CheckLetter('S');
    game.CheckLetter('T');
    game.CheckLetter('r');
    Assert.That(game.GetWordToGuess(), Is.EqualTo("BA_ERS"));
  }

  [Test]
  public void Game_DeclaresWin_IfAllLettersGuessed()
  {
    WordChooser mockChooser = Substitute.For<WordChooser>();
    mockChooser.GetRandomWordFromDictionary().Returns("BAKERS");
    Game game = new Game(mockChooser);
    game.CheckLetter('A');
    game.CheckLetter('e');
    game.CheckLetter('K');
    game.CheckLetter('s');
    game.CheckLetter('R');
    game.GetWordToGuess();
    Assert.That(game.win, Is.EqualTo(true));
  }

    [Test]
  public void Game_DeclaresWin_IfAllLettersGuessed_WordWithDuplicateLetters()
  {
    WordChooser mockChooser = Substitute.For<WordChooser>();
    mockChooser.GetRandomWordFromDictionary().Returns("COOLEST");
    Game game = new Game(mockChooser);
    game.CheckLetter('l');
    game.CheckLetter('o');
    game.CheckLetter('E');
    game.CheckLetter('s');
    game.CheckLetter('T');
    game.GetWordToGuess();
    Assert.That(game.win, Is.EqualTo(true));
  }
}