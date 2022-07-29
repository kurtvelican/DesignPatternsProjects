using System;
using System.Collections.Generic;

namespace SingletonUygulama
{
    public class YukDengeleyici
    {
        private static YukDengeleyici nesne;
        private List<string> sunucular = new List<string>();
        private Random rnd = new Random();

        //lock işlemi için gerekli
        private static object kilit = new object();

        protected YukDengeleyici()
        {
            sunucular.Add("Sunucu_1");
            sunucular.Add("Sunucu_2");
            sunucular.Add("Sunucu_3");
            sunucular.Add("Sunucu_4");
            sunucular.Add("Sunucu_5");
        }

        public static YukDengeleyici YukDengeleyiciGetir()
        {
            //multi thread
            
            /*if (nesne == null)
            {
                lock (kilit)
                {
                    if (nesne == null)
                    {
                        nesne = new YukDengeleyici();
                    }
                }
            }
            return nesne;*/
            
            //single thread
            
            if (nesne == null)
            {
                nesne = new YukDengeleyici();
            }
            return nesne;
        }

        public string Sunucu
        {
            get
            {
                int r = rnd.Next(sunucular.Count);
                return sunucular[r].ToString();
            }
        }
    }
}