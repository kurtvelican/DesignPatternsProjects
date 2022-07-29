namespace BuilderPizzaExample
{
    public class HawaiianPizzaBuilder : PizzaBuilder
    {
        private Pizza _pizza = new Pizza();
        public override void buildDough()
        {
            _pizza.setDough("Slim");
        }

        public override void buildSauce()
        {
           _pizza.setSauce("Sweet Chili");
        }

        public override void buildTopping()
        {
            _pizza.setTopping("Pineapple");
        }

        public override Pizza getPizza()
        {
            return _pizza;
        }
    }
}