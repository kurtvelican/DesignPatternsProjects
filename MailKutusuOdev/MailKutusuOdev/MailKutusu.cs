using System;

namespace MailKutusuOdev
{
    public class MailKutusu
    {
        private String sol = "Mail Kutusu Solda ";
        private String sol_ust = "Mail Kutusu Sol Üstte ";
        
        private String u = "Mail Kutusunun boyutu 300";
        private String k = "Mail Kutusunun boyutu 200";

        public string Sol
        {
            get => sol;
            set => sol = value;
        }

        public string SolUst
        {
            get => sol_ust;
            set => sol_ust = value;
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