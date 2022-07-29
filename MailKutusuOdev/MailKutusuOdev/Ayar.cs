using System;

namespace MailKutusuOdev
{
    public class Ayar
    {
        private static Ayar ayar;

        private static object kilit = new object();

        private Ayar()
        {
        }

        public static Ayar Nesne()
        {
            if (ayar == null)
            {
                lock (kilit)
                {
                    if (ayar == null)
                    {
                        ayar = new Ayar();
                    }
                }
            }
            return ayar;
        }
        MailKutusu mailKutusu = new MailKutusu();
        Basliklar basliklar = new Basliklar();
        MailIcerigi mailIcerigi = new MailIcerigi();
        private String ayar1;
        private String ayar2;
        private String ayar3;
        
        public String Ayarlama(int ayar)
        {
            if (ayar == 1)
            {
                ayar1 = mailKutusu.Sol + " ve " + mailKutusu.U + " ya da " + mailKutusu.K + "\n" 
                + basliklar.SagUst + " ve " + basliklar.U + " ya da " + basliklar.K + "\n"
                + mailIcerigi.SagAlt + " ve " + mailIcerigi.U + " ya da " + mailIcerigi.K;
                return ayar1;
            }
            else if (ayar == 2)
            {
                ayar2 = mailKutusu.Sol + " ve " + mailKutusu.U +  " ya da " + mailKutusu.K + "\n" 
                + basliklar.Orta + " ve " + basliklar.U + " ya da " + basliklar.K + "\n" 
                + mailIcerigi.Sag + " ve " + mailIcerigi.U + " ya da " + mailIcerigi.K;
                return ayar2;
            }
            else if (ayar == 3)
            {
                ayar3 = mailKutusu.SolUst + " ve " + mailKutusu.U + " ya da " + mailKutusu.K + "\n"
                + basliklar.SagUst + " ve " + basliklar.U + " ya da " + basliklar.K + "\n"
                + mailIcerigi.Alt + " ve " + mailIcerigi.U + " ya da " + mailIcerigi.K;
                return ayar3;
            }
            else
            {
                return "Yanlış girdiniz";
            }
        }
        
    }
}