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
        public long Telefon { get; set; }

        public string ReturnName()
        {
            return Name + " " + Surname;
        }

        public string show()
        {
            return "DATI CLIENTE :\nNome : " + Name + "\nCognome : " + Surname + "\nIndirizzo : " + Address  + "\nCittà : " + City + "\nTelefono : " + Telefon;
        }
    }
}
