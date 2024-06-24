namespace FactorDesignPattern
{
    public interface IDocumentFactory
    {
        public IDocument CreateDocument(string docType);
    }
}