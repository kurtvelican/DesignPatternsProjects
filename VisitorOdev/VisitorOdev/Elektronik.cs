namespace VisitorOdev
{
    public abstract class Elektronik
    {
        private string cihazIsmi;

        protected Elektronik(string cihazIsmi)
        {
            this.cihazIsmi = cihazIsmi;
        }

        public string CihazIsmi
        {
            get => cihazIsmi;
            set => cihazIsmi = value;
        }

        public abstract void visit(Yazici yazici);
    }
}