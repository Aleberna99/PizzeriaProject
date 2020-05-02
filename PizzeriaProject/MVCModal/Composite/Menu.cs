using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVCModal
{
    public class Menu : IOrder 
    {
        private IList<IOrder> menu = new List<IOrder>();
        private string name;

        public Menu(string name)
        {
            this.name = name;
        }

        public IOrder SearchMenu(string name)
        {
            foreach (var m in menu)
            {
                if (m.ReturnName() == name)
                {
                    return m;
                }
            }

            return null;
        }

        public IEnumerable<IOrder> ReturnMenu()
        {
            return menu;
        }

        public void AddMenu(IOrder product)
        {
            menu.Add(product);
        }

        public void RemoveMenu(IOrder product)
        {
            menu.Remove(product);
        }

        public string ReturnName()
        {
            return name;
        }

        public double ReturnPrice()
        {
            double totalPrice = 0.00;
            foreach (var m in menu)
            {
                totalPrice += m.ReturnPrice();
            }
            return totalPrice;
        }

        public string show()
        {
            string order = "";

            foreach (var m in menu)
            {
                order = order + m.show() + "\n\n";
            }

            return order;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
