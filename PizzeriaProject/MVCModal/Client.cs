using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVCModal
{
    public class Client
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public long Telephone { get; set; }

        public string ReturnName()
        {
            return Name + " " + Surname;
        }

        public string Show()
        {
            return "DATI CLIENTE :\nNome : " + Name + "\nCognome : " + Surname + "\nIndirizzo : " + Address  + "\nCittà : " + City + "\nTelefono : " + Telephone;
        }
    }
}
