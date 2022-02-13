using System;
using System.Collections.Generic;


namespace MIKOLAJCZAK_ANTOINE_TP6_ST2TRD
{
    public class Pizza
    {
        private List<string> toppingPizza = new List<string>();


        public List<string> ToppingPizza()
        {
            return toppingPizza;
        }

        public void OrderResume()
        {
            Console.WriteLine("Here is the pizza with the followings topping :");
            Console.WriteLine(string.Join(", ", toppingPizza));
        }
    }
    
}