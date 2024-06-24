namespace FactorDesignPattern
{
    public class PdfDocument : IDocument
    {

        public void Close()
        {
            Console.Write("Closing Pdf Document");
        }

        public void GetInformation()
        {
            Console.Write("I am a Pdf Document");
        }

        public void Open()
        {
            Console.Write("Opening Pdf Document");
        }
    }
}