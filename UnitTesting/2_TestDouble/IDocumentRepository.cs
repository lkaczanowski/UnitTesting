namespace UnitTesting._2_TestDouble
{
  public interface IDocumentRepository
  {
    void Update(Document document);

    Document Get(int documentNumber);
  }
}
