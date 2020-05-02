using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVCController
{
    public interface IBuilder
    {
        void SetName(string name);
        void AddIngredient(string ingredient);
        void SetPrice(double price);
    }
}
