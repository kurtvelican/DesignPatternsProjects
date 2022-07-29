using System;

namespace MailKutusuOdev
{
    public class Basliklar
    {
        private String sag_ust = "Başlıklar Sağ Üstte ";
        private String orta = "Başlıklar Ortada ";
        
        private String u = "Başlıkların boyutu 600";
        private String k = "Başlıkların boyutu 300";

        public string SagUst
        {
            get => sag_ust;
            set => sag_ust = value;
        }

        public string Orta
        {
            get => orta;
            set => orta = value;
        }

        public string U
        {
            get => u;
            set => u = value;
        }

        public string K
        {
            get => k;
            set => k = value;
        }
    }
}