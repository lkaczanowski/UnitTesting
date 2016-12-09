using System;

using NUnit.Framework;

using UnitTesting._2_TestDouble;

namespace UnitTesting.Tests._2_TestDouble
{
  [TestFixture]
  public class DocumentSignerTests
  {
    private DocumentSigner _sut;

    [Test]
    public void Test_with_mock_repository()
    {
      // assign
      var mockDocumentRepository = new MockDocumentRepository();

      _sut = new DocumentSigner(mockDocumentRepository);

      // act
      _sut.Sign(4);

      // assert
      Assert.IsTrue(mockDocumentRepository.Verify_Update);
    }

    /// <summary>
    /// Dummy
    /// </summary>
    private class DummyDocumentRepository : IDocumentRepository
    {
      public void Update(Document document)
      {
        throw new NotImplementedException();
      }

      public Document Get(int documentNumber)
      {
        throw new NotImplementedException();
      }
    }

    /// <summary>
    /// Stub
    /// </summary>
    private class StubDocumentRepository : IDocumentRepository
    {
      public void Update(Document document)
      {
      }

      public Document Get(int documentNumber)
      {
        return new Document
        {
          Number = 4
        };
      }
    }

    /// <summary>
    /// Fake
    /// </summary>
    private class FakeDocumentRepository : IDocumentRepository
    {
      public void Update(Document document)
      {
      }

      public Document Get(int documentNumber)
      {
        if (documentNumber < 0)
        {
          throw new Exception();
        }

        return new Document
        {
          Number = documentNumber
        };
      }
    }

    /// <summary>
    /// Mock
    /// </summary>
    private class MockDocumentRepository : IDocumentRepository
    {
      public void Update(Document document)
      {
        Verify_Update = true;
      }

      public Document Get(int documentNumber)
      {
        Verify_Get = true;

        return new Document();
      }

      public bool Verify_Update { get; private set; }

      public bool Verify_Get { get; private set; }
    }
  }
}