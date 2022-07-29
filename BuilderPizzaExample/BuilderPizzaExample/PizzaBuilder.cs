namespace BuilderPizzaExample
{
    public abstract class PizzaBuilder
    {
        private Pizza _pizza;
        public abstract void buildDough();
        public abstract void buildSauce();
        public abstract void buildTopping();
        public abstract Pizza getPizza();
        
        public void CreateNewPizzaProduct()
        {
            _pizza = new Pizza();
        }
    }
}