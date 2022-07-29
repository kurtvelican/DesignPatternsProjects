namespace SingletonUygulama
{
    public class Singleton3
    {
        private static Singleton3 nesne3;
        private static object kilit = new object();
        private Singleton3()
        {
        }

        public static Singleton3 Nesne3()
        {
            if (nesne3 == null)
            {
                lock (kilit)
                {
                    if (nesne3 == null)
                    {
                        nesne3 = new Singleton3();
                    }
                }
            }
            return nesne3;
        }
    }
}