namespace MIKOLAJCZAK_ANTOINE_TP6_ST2TRD
{
    public class builder
    {
        protected Pizza pizza;

        public Pizza getPizza()
        {
            return pizza;
        }

        public void createPizza()
        {
            pizza = new Pizza();
        }

        public builder addGarlic()
        {
            pizza.ToppingPizza().Add("garlic");
            return this;
        }
        
        public builder addCheese()
        {
            pizza.ToppingPizza().Add("cheese");
            return this;
        }
        
        public builder addPepper()
        {
            pizza.ToppingPizza().Add("pepper");
            return this;
        }
        
        public builder addBeer()
        {
            pizza.ToppingPizza().Add("beer");
            return this;
        }
        
        public builder addFries()
        {
            pizza.ToppingPizza().Add("Fries");
            return this;
        }
        
        public builder addFish()
        {
            pizza.ToppingPizza().Add("fish");
            return this;
        }
    }

    
}