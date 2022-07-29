namespace ChainOfResponsibilityDirectorExample
{
    public class Purchase
    {
        private int number;
        private double amount;
        private string purpose;

        public Purchase(int number, double amount, string purpose)
        {
            this.number = number;
            this.amount = amount;
            this.purpose = purpose;
        }

        public int Number
        {
            get => number;
            set => number = value;
        }

        public double Amount
        {
            get => amount;
            set => amount = value;
        }

        public string Purpose
        {
            get => purpose;
            set => purpose = value;
        }
    }
}