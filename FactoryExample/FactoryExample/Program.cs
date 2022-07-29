using System;

namespace FactoryExample
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*normal kullanım
            PDFReader pdfReader = new PDFReader();
            pdfReader.Read();
            pdfReader.Extract();*/
            
            /*1. Kullanım
            DocumentReaderFactory readerFactory = new DocumentReaderFactory();
            IDocumentReader pdfReader = (PDFReader) readerFactory.Get("PDF");
            pdfReader.Read();
            pdfReader.Extract();*/
            
            //1.1 Generic Version
            IDocumentReader pdfReader1 = (PDFReader) DocumentFactory.Get();
            IDocumentReader wordReader = (MsWordReader) DocumentFactory.Get();
            
            Console.ReadLine();



        }
    }
}