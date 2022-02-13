using System;
using System.Text;

namespace MIKOLAJCZAK_ANTOINE_TP6_ST2TRD
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // question 2
            
            builder pizzaBuilder = new builder();
            pizzaBuilder.createPizza();
            Pizza pizzaDuChef = pizzaBuilder.addBeer().addCheese().addFish().addFries().getPizza();
            pizzaDuChef.OrderResume();
            
            
            //question 4

            Iphone5 monIphone = new Iphone5();
            


        }
    }
}