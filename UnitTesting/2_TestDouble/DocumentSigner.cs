namespace UnitTesting._2_TestDouble
{
  public class DocumentSigner
  {
    private readonly IDocumentRepository _documentRepository;

    public DocumentSigner(IDocumentRepository documentRepository)
    {
      _documentRepository = documentRepository;
    }

    public void Sign(int documentNumber)
    {
      var document = _documentRepository.Get(documentNumber);

      // Sign document...

      _documentRepository.Update(document);
    }
  }
}
