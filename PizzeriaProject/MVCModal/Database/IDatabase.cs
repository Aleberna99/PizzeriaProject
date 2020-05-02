using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVCModal
{
    public interface IDatabase
    {
        void SaveData(IOrder ordine, Client cliente);
    }
}
