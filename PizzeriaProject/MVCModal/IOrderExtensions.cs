using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MVCModal
{
    public static class IOrderExtensions
    {
        public static ListViewItem ToListViewItem(this IOrder menu, Drink drink, Pizza pizza)
        {
            string[] row = { menu.ReturnName(), pizza.ReturnName(), drink.ReturnName(), menu.ReturnPrice().ToString() };
            return new ListViewItem(row);
        }

        public static string ToMenu(this ListViewItem menu)
        {
            return menu.SubItems[0].Text;
        }
    }
}
