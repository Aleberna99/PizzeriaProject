using MVCModal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVCController
{
    public class TotalQuantity : IVisitor
    {
        private int totalPizze = 0;
        private int totalDrink = 0;
        private int totalMenu = 0;

        public void Visit(Drink drink)
        {
            totalDrink++;
        }
        public void Visit(Menu menu)
        {
            totalMenu++;
        }
        public void Visit(Pizza pizza)
        {
            totalPizze++;
        }

        public void Reset()
        {
            totalPizze = 0;
            totalDrink = 0;
            totalMenu = 0;
        }

        public int GetTotalPizze()
        {
            return totalPizze;
        }

        public int GetTotalDrink()
        {
            return totalDrink;
        }

        public int GetTotalMenu()
        {
            return totalMenu;
        }
    }
}
