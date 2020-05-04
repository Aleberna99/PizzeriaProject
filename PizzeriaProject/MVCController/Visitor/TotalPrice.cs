using MVCModal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVCController
{
    public class TotalPrice : IVisitor
    {
        private double totalPizze = 0;
        private double totalDrink = 0;
        private double totalMenu = 0;

        public void Visit(Drink drink)
        {
            totalDrink += drink.ReturnPrice();
        }
        public void Visit(Menu menu)
        {
            totalMenu += menu.ReturnPrice();
        }
        public void Visit(Pizza pizza)
        {
            totalPizze += pizza.ReturnPrice();
        }

        public void Reset()
        {
            totalPizze = 0;
            totalDrink = 0;
            totalMenu = 0;
        }

        public object GetTotalPizze()
        {
            return totalPizze;
        }

        public object GetTotalDrink()
        {
            return totalDrink;
        }

        public object GetTotalMenu()
        {
            return totalMenu;
        }
    }
}
