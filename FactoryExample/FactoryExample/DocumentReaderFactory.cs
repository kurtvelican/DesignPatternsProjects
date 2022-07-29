namespace FactoryExample
{
    public class DocumentReaderFactory
    {
        //burada string tipi enum da kullanabiliriz.

        public IDocumentReader Get(string readerType)
        {
            switch (readerType)
            {
                case "PDF":
                    return new PDFReader();
                case "MsWord":
                    return new MsWordReader();
                default:
                    return new PDFReader();
                //örneğin burası için NULL object deseni kullanılarak null tanımlı bir sınıf yazılabilir.
                //veya exception fırlatılır  throw new Expection("Invalid DocumentReader Type");
            }
        }
    }
}