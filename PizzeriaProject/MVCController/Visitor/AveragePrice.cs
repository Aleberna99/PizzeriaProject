using MVCModal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVCController
{
    public class AveragePrice : IVisitor
    {
        private List<double> totalPizze = new List<double>();
        private List<double> totalDrink = new List<double>();
        private List<double> totalMenu = new List<double>();

        public double ResultPizza()
        {
            return totalPizze.Count > 0 ? totalPizze.Average() : 0;
        }
        public double ResultBevanda()
        {
            return totalDrink.Count > 0 ? totalDrink.Average() : 0;
        }
        public double ResultMenu()
        {
            return totalMenu.Count > 0 ? totalMenu.Average() : 0;
        }

        public void Visit(Drink drink)
        {
            totalDrink.Add(drink.ReturnPrice());
        }
        public void Visit(Menu menu)
        {
            totalMenu.Add(menu.ReturnPrice());
        }
        public void Visit(Pizza pizza)
        {
            totalPizze.Add(pizza.ReturnPrice());
        }

        public void Reset()
        {
            totalPizze.Clear();
            totalDrink.Clear();
            totalMenu.Clear();
        }
    }
}
