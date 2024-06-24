using System.IO.Compression;

namespace FactorDesignPattern
{
    public interface IDocument
    {
        public void Open();
        public void Close();
        public void GetInformation();
        public void ShowInformation()
        {
            Console.WriteLine("I am an Interface");
        }
    }
}