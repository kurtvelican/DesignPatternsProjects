namespace StrategyDers
{
    public class ContextClass
    {
        private Strategy _strategy;

        public void setStrategy(Strategy strategy)
        {
            this._strategy = strategy;
        }

        public void arayuzGoster()
        {
            _strategy.arayuzSec();
            
        }

        public void fiyatGetir()
        {
            _strategy.fiyatHesapla();
        }
    }
}