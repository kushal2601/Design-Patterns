namespace FactorDesignPattern
{
    public class WordDocument : IDocument{
        public void Close()
        {
            Console.Write("Closing Word Document");
        }

        public void GetInformation()
        {
            Console.Write("I am a Word Document");
        }

        public void Open(){
            Console.Write("Opening Word Document");
        }
    }
}