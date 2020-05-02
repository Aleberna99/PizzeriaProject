using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVCModal
{
    public class Pizza : IOrder 
    {
        private List<object> ingredients = new List<object>();
        public double price;
        public string name;
        public void Add(string ingrediente)
        {
            ingredients.Add(ingrediente);
        }

        public void SetName(string nome)
        {
            this.name = nome;
        }

        public void SetPrice(double prezzo)
        {
            this.price = prezzo;
        }
        public string ListParts()
        {
            string str = string.Join(", ", ingredients);
            return "Ingredienti : " + str;
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
            return ReturnName() + "\n" + ListParts() + "\nPrezzo : " + ReturnPrice() + "$";
        }

        public void AddMenu(IOrder menu) { } //inutile
        public void RemoveMenu(IOrder menu) { } //inutile
        public IOrder SearchMenu(string name) { return null; }

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
