using MVCController;
using MVCModal;
using MVCView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WinFormMVC.Controller;

namespace WinFormMVC.View
{
    public partial class PizzeriaView : Form, IPizzeriaView
    {
        PizzeriaController _controller;
        private ControllComboBox controllComboBox;
        private ControllDataClient controllDataClient;

        public PizzeriaView()
        {
            InitializeComponent();
            controllComboBox = new ControllComboBox(cmbBevanda, cmbPizza);
            controllDataClient = new ControllDataClient(txtnome, txtcognome, txtindirizzo, txtcitta, txtTelefono);
        }
        private void btnAggiungiMenu_Click(object sender, EventArgs e)
        {
            if (cmbPizza.Text != "" && cmbBevanda.Text != "")
            {
                this._controller.AddMenu();
                controllComboBox.ResetComboBox();
                txtPrezzoBevanda.Text = "";
                txtPrezzoPizza.Text = "";
                lblIngredienti.Text = "";
            }
            else
            {
                MessageBox.Show(" IMMETTERE LA PIZZA E LA BEVANDA CORRETTAMENTE !!", "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnRimuoviMenu_Click(object sender, EventArgs e)
        {
            this._controller.RemoveMenu();
        }

        private void cmbBevanda_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPrezzoBevanda.Text = controllComboBox.ControllPriceDrink().ToString();
        }

        private void cmbPizza_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPrezzoPizza.Text = controllComboBox.ControllPricePizza().ToString();
            lblIngredienti.Text = controllComboBox.ControllIngredient().ToString();
        }


        private void btnConfermaOrdine_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                panel1.Enabled = false;
                panel3.Enabled = false;
                panel2.Enabled = true;
            }
            else
            {
                MessageBox.Show("AGGIUNGERE ALL'ORDINE ALMENO UN MENU !!", "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfermaDatiCliente_Click(object sender, EventArgs e)
        {
            if (controllDataClient.ControllTextBox())
            {
                if (controllDataClient.ControllTelefon())
                {
                    this._controller.CreateClient();
                }
                else
                {
                    MessageBox.Show(" NUMERO DI TELEFONO NON VALIDO !!", " ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(" INSERIRE TUTTI I CAMPI CORRETTAMENTE !!", " ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        public void SetController(PizzeriaController controller)
        {
            throw new NotImplementedException();
        }

        public void AddInListView(IOrder menu, Drink drink, Pizza pizza)
        {
            throw new NotImplementedException();
        }

        public void PrintCalculations(TotalPrice totalPrice, AveragePrice averagePrice, TotalQuantity totalQuantity)
        {
            throw new NotImplementedException();
        }

        public void RemoveOnListView()
        {
            throw new NotImplementedException();
        }

        public bool PrintReceipt(IOrder ordine, Client cliente)
        {
            throw new NotImplementedException();
        }

        public string ReturnNameMenuSelected()
        {
            throw new NotImplementedException();
        }

        public void CloseProgramm()
        {
            throw new NotImplementedException();
        }

        public void ModifyOrder()
        {
            throw new NotImplementedException();
        }

        public string NamePizza => throw new NotImplementedException();

        public string NameDrink => throw new NotImplementedException();

        public double PriceDrink => throw new NotImplementedException();

        public string NameClient => throw new NotImplementedException();

        public string SurnameClient => throw new NotImplementedException();

        public string CityClient => throw new NotImplementedException();

        public string AddressClient => throw new NotImplementedException();

        public long TelefonClient => throw new NotImplementedException();
    }
}
