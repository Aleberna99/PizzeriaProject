using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVCModal
{
    public interface IVisitor
    {
        void Visit(Pizza pizza);
        void Visit(Drink drink);
        void Visit(Menu menu);
        void Reset();
    }
}
