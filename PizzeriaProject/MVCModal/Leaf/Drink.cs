using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVCModal
{
    public class Drink : IOrder 
    {
        private string name;
        private double price;

        public Drink(string name, double price)
        {
            this.name = name;
            this.price = price;
        }
        public string ReturnName()
        {
            return name;
        }

        public double ReturnPrice()
        {
            return price;
        }

        public string show()
        {
            return ReturnName() + "\nPrezzo : " + ReturnPrice() + "$";
        }

        public IOrder SearchMenu(string nome) { return null; }
        public void AddMenu(IOrder menu) { } //inutile
        public void RemoveMenu(IOrder menu) { } //inutile

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public IEnumerable<IOrder> ReturnMenu()
        {
            return null;
        }
    }
}
