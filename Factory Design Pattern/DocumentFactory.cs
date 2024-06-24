namespace FactorDesignPattern
{
    public enum DocumentType
    {
        PDF,
        Word
    }
    public class DocumentFactory : IDocumentFactory
    {
        public IDocument CreateDocument(string documentType)
        {
            if (Enum.TryParse(typeof(DocumentType), documentType, true, out var type))
            {
                Console.WriteLine($"Type : {type}");

                switch (type)
                {
                    case DocumentType.PDF:
                        return new PdfDocument();
                    case DocumentType.Word:
                        return new WordDocument();
                    default:
                        {
                            throw new ArgumentException("Unsupported document type");
                        }
                }
            }
            throw new ArgumentException("Not a valid document type");

        }
    }
}