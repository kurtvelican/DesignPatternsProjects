namespace StrategyDers
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Strategy strategy = new HaftaSonu();
            strategy.arayuzSec();
            strategy.fiyatHesapla();
            
            Strategy strategy2 = new Yilbasi();
            strategy2.arayuzSec();
            strategy2.fiyatHesapla();*/

            ContextClass contextClass = new ContextClass();
            contextClass.setStrategy(new Yilbasi());
            contextClass.arayuzGoster();
            contextClass.fiyatGetir();
        }
    }
}