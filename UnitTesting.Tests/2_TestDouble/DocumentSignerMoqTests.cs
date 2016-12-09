using Moq;

using NUnit.Framework;

using UnitTesting._2_TestDouble;

namespace UnitTesting.Tests._2_TestDouble
{
  [TestFixture]
  public class DocumentSignerMoqTests
  {
    private DocumentSigner _sut;

    [Test]
    public void Test_using_moq()
    {
      // assign
      var dummyDocumentRepository = It.IsAny<IDocumentRepository>(); // dummy

      var mockDocumentRepository = new Mock<IDocumentRepository>(); // stub, fake, mock

      var document = new Document
      {
        Number = 1
      };

      mockDocumentRepository.Setup(x => x.Get(It.IsAny<int>())).Returns(document); // stub method

      _sut = new DocumentSigner(mockDocumentRepository.Object);

      // act
      _sut.Sign(4);

      // assert
      mockDocumentRepository.Verify(x => x.Update(document));
    }
  }
}