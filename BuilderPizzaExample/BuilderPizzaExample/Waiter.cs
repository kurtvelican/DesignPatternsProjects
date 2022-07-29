namespace BuilderPizzaExample
{
    public class Waiter //Director
    {
        private PizzaBuilder _pizzaBuilder;
        public void setPizzaBuilder(PizzaBuilder pizzaBuilder)
        {
            this._pizzaBuilder = pizzaBuilder;
        }

        public void constructPizza()
        {
            _pizzaBuilder.CreateNewPizzaProduct();
            _pizzaBuilder.buildDough();
            _pizzaBuilder.buildSauce();
            _pizzaBuilder.buildTopping();
        }

        public Pizza getPizza()
        {
            return _pizzaBuilder.getPizza();
        }
        
        
    }
}