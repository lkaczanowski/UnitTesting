namespace UnitTesting._4_TDD
{
  public class FizzBuzzer
  {
    public string FizzBuzz(int number)
    {
      if (number % 3 == 0)
      {
        return "Fizz";
      }

      return string.Empty;
    }
  }
}
