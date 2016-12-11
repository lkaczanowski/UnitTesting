using System;

using FsCheck;

using NUnit.Framework;

using UnitTesting._3_FsCheck;

namespace UnitTesting.Tests._3_FsCheck
{
  [TestFixture]
  public class CalculatorTests
  {
    [Test]
    public void Test_Sum_properties()
    {
      var sut = new Calculator();

      Func<int, int, bool> reverseParamDoesNotMatter = (a, b) => sut.Sum(a, b) == sut.Sum(b, a);

      Func<int, bool> addingZeroToNumberReturnsNumber = a => sut.Sum(a, 0) == a;

      Func<int, bool> addingOneTwiceEqualsAddingTwoOnce = a => sut.Sum(sut.Sum(a, 1), 1) == sut.Sum(a, 2);

      Func<int, int, bool> propertiesOfAdding = (a, b) =>
        reverseParamDoesNotMatter(a, b) &&
        addingZeroToNumberReturnsNumber(a) &&
        addingOneTwiceEqualsAddingTwoOnce(a);

      Prop.ForAll(propertiesOfAdding).QuickCheckThrowOnFailure();
    }
  }
}
