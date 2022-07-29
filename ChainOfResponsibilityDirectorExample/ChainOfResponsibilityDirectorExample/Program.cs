namespace ChainOfResponsibilityDirectorExample
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            Approver veli = new Director();
            Approver can = new VicePresident();
            Approver kurt = new President();
            
            veli.SetSuccessor(can);
            can.SetSuccessor(kurt);
            kurt.SetSuccessor(veli);

            Purchase purchase = new Purchase(5,302000,"Supplies");
            
            kurt.ProcessRequest(purchase);

            purchase = new Purchase(6, 22000, "Project 1");
            
            can.ProcessRequest(purchase);

            purchase = new Purchase(7, 85000, "Project 2");
            
            can.ProcessRequest(purchase);

        }
    }
}