using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MVCView
{
    public class ControllDataClient
    {
        private TextBox name;
        private TextBox surname;
        private TextBox address;
        private TextBox city;
        private TextBox telefon;

        public ControllDataClient(TextBox nome, TextBox cogn, TextBox ind, TextBox cit, TextBox tel)
        {
            this.name = nome;
            this.surname = cogn;
            this.address = ind;
            this.city = cit;
            this.telefon = tel;
        }

        public void ResetTextBox()
        {
            name.Text = "";
            surname.Text = "";
            address.Text = "";
            city.Text = "";
            telefon.Text = "";
        }
        public bool ControllTextBox()
        {
            return !string.IsNullOrEmpty(name.Text)
                && !string.IsNullOrEmpty(surname.Text)
                && !string.IsNullOrEmpty(address.Text)
                && !string.IsNullOrEmpty(city.Text)
                && !string.IsNullOrEmpty(telefon.Text);
        }
        public bool ControllTelefon()
        {
            if (telefon.Text.Length < 10)
            {
                return false;
            }
            else return true;
        }

        public void ControllInt(KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}
