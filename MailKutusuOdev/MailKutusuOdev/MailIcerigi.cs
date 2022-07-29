using System;

namespace MailKutusuOdev
{
    public class MailIcerigi
    {
        private String sag = "Mail İçeriği Sağda ";
        private String sag_alt = "Mail İçeriği Sağ Altta ";
        private String alt = "Mail İçeriği Altta ";
        
        private String u ="Mail İçeriğinin boyutu 900";
        private String k ="Mail İçeriğinin boyutu 600";

        public string Sag
        {
            get => sag;
            set => sag = value;
        }

        public string SagAlt
        {
            get => sag_alt;
            set => sag_alt = value;
        }

        public string Alt
        {
            get => alt;
            set => alt = value;
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