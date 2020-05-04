using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MVCView
{
    public class ControllDataClient
    {
        private TextBox cmbName;
        private TextBox cmbSurname;
        private TextBox cmbAddress;
        private TextBox cmbCity;
        private TextBox cmbTelefon;

        public ControllDataClient(TextBox nome, TextBox cogn, TextBox ind, TextBox cit, TextBox tel)
        {
            this.cmbName = nome;
            this.cmbSurname = cogn;
            this.cmbAddress = ind;
            this.cmbCity = cit;
            this.cmbTelefon = tel;
        }

        public void ResetTextBox()
        {
            cmbName.Text = "";
            cmbSurname.Text = "";
            cmbAddress.Text = "";
            cmbCity.Text = "";
            cmbTelefon.Text = "";
        }
        public bool ControllTextBox()
        {
            return !string.IsNullOrEmpty(cmbName.Text)
                && !string.IsNullOrEmpty(cmbSurname.Text)
                && !string.IsNullOrEmpty(cmbAddress.Text)
                && !string.IsNullOrEmpty(cmbCity.Text)
                && !string.IsNullOrEmpty(cmbTelefon.Text);
        }
        public bool ControllTelefon()
        {
            if (cmbTelefon.Text.Length < 10)
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
