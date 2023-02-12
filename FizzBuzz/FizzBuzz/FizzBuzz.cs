namespace FizzBuzz
{
  public class FizzBuzz
  {
    public string For(int num)
    {
      if (num % 3 == 0) 
      {
        return "Fizz";
      }
      else
      {
        return num.ToString();
      }
    }

  }
}