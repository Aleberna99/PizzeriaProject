using MVCModal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVCController
{
    class ConcreteBuilder : IBuilder 
    {
        private Pizza pizza;
        public ConcreteBuilder()
        {
            this.Reset();
        }
        private void Reset()
        {
            pizza = new Pizza();
        }

        public void SetName(string name)
        {
            pizza.name = name;
        }
        public void AddIngredient(string ingredient)
        {
            pizza.Add(ingredient);
        }
        public void SetPrice(double price)
        {
            pizza.price = price;
        }

        public Pizza GetProduct()
        {
            Pizza result = pizza;
            this.Reset();
            return result;

        }
    }
}
