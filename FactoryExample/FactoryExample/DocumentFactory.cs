namespace FactoryExample
{
    public class DocumentFactory 
    //where T : IDocumentReader, new()
    {
        private static IDocumentReader opr = null;

        public static IDocumentReader Get()
        {
            return opr;// = new T();
        }
    }
}