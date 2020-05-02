using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVCModal
{
    public interface IOrder
    {
        string ReturnName();
        double ReturnPrice();
        void AddMenu(IOrder menu);
        void RemoveMenu(IOrder menu);
        IOrder SearchMenu(string name);
        IEnumerable<IOrder> ReturnMenu();
        string show();
        void Accept(IVisitor visitor);
    }
}
