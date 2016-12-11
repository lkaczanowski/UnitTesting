using System;

namespace UnitTesting._4_TDD
{
  public class FizzBuzzer
  {
    public string FizzBuzz(int number)
    {
      if (IsFizzBuzz(number))
      {
        return "FizzBuzz";
      }

      if (IsFizz(number))
      {
        return "Fizz";
      }

      if (IsBuzz(number))
      {
        return "Buzz";
      }

      return number.ToString();
    }

    private static bool IsFizz(int number) => IsMultiplierOf(3)(number);

    private static bool IsBuzz(int number) => IsMultiplierOf(5)(number);

    private static bool IsFizzBuzz(int number) => IsMultiplierOf(15)(number);

    private static Func<int, bool> IsMultiplierOf(int multiplier) => number => number % multiplier == 0;
  }
}
