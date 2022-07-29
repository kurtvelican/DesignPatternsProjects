namespace VisitorOdev
{
    public abstract class Yazici
    {
        private string yaziciIsmi;

        protected Yazici(string yaziciIsmi)
        {
            this.yaziciIsmi = yaziciIsmi;
        }

        public string YaziciIsmi
        {
            get => yaziciIsmi;
            set => yaziciIsmi = value;
        }

        public abstract void accept(Elektronik elektronik);
    }
}