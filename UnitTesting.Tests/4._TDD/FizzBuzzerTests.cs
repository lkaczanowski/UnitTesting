using NUnit.Framework;

using UnitTesting._4_TDD;

namespace UnitTesting.Tests._4._TDD
{
  [TestFixture]
  public class FizzBuzzerTests
  {
    private FizzBuzzer _sut;

    [Test]
    public void When_number_is_multiplier_of_3_then_return_Fizz([Values(3, 6, 9, 12)] int number)
    {
      // arrange
      var expected = "Fizz";

      _sut = new FizzBuzzer();

      // act
      var actual = _sut.FizzBuzz(number);

      // assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void When_number_is_multiplier_of_5_then_return_Buzz([Values(5, 10, 20, 25)] int number)
    {
      // arrange
      var expected = "Buzz";

      _sut = new FizzBuzzer();

      // act
      var actual = _sut.FizzBuzz(number);

      // assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void When_number_is_multiplier_of_3_and_5_then_return_FizzBuzz([Values(15, 30, 45)] int number)
    {
      // arrange
      var expected = "FizzBuzz";

      _sut = new FizzBuzzer();

      // act
      var actual = _sut.FizzBuzz(number);

      // assert
      Assert.AreEqual(expected, actual);
    }

    [TestCase(2, "2")]
    [TestCase(4, "4")]
    [TestCase(7, "7")]
    public void When_number_is_not_multiplier_of_3_or_5_then_return_number_as_string(int number, string expected)
    {
      // arrange
      _sut = new FizzBuzzer();

      // act
      var actual = _sut.FizzBuzz(number);

      // assert
      Assert.AreEqual(expected, actual);
    }
  }
}
