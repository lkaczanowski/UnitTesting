using NUnit.Framework;

using UnitTesting._4_TDD;

namespace UnitTesting.Tests._4._TDD
{
  [TestFixture]
  public class FizzBuzzerTests
  {
    private FizzBuzzer _sut;

    [Test]
    public void When_number_is_multiplier_of_3_then_return_Fizz()
    {
      // arrange
      var expected = "Fizz";

      _sut = new FizzBuzzer();

      // act
      var actual = _sut.FizzBuzz(6);

      // assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void When_number_is_multiplier_of_5_then_return_Buzz()
    {
      // arrange
      var expected = "Buzz";

      _sut = new FizzBuzzer();

      // act
      var actual = _sut.FizzBuzz(10);

      // assert
      Assert.AreEqual(expected, actual);
    }
  }
}
