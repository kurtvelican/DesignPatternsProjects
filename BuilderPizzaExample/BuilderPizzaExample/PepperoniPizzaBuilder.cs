namespace BuilderPizzaExample
{
    public class PepperoniPizzaBuilder : PizzaBuilder
    {
        private Pizza _pizza = new Pizza();
        
        public override void buildDough()
        {
            _pizza.setDough("Bold");
        }

        public override void buildSauce()
        {
            _pizza.setSauce("Tomato");
        }

        public override void buildTopping()
        {
            _pizza.setTopping("Pepperoni");
        }

        public override Pizza getPizza()
        {
            return _pizza;
        }
    }
}