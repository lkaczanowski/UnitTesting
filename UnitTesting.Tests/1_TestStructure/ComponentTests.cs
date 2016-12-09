using NUnit.Framework;

namespace UnitTesting.Tests._1_TestStructure
{
  [TestFixture]
  public class ComponentTests
  {
    // System Under Test
    private ComponentTests _sut;

    [OneTimeSetUp]
    public void TestFixtureSetup()
    {
      // Ustawienie stanu (globalnego) przed uruchomieniem testów
    }

    [OneTimeTearDown]
    public void TestFixtureTeardown()
    {
      // Przywrócenie stanu po uruchomieniu testów
    }

    [SetUp]
    public void Setup()
    {
      // Inicjalizacja stanu przed uruchomieniem testu
    }

    [TearDown]
    public void Teardown()
    {
      // Przywrócenie stanu, posprzątanie zasobów etc. po uruchomieniu testu
    }

    [Test]
    public void Testing_some_assumption()
    {
      // Test
    }
  }
}