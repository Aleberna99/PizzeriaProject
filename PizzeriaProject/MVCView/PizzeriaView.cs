﻿using MVCController;
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

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.controllDataClient.ControllInt(e);
        }




        public void SetController(PizzeriaController controller)
        {
            _controller = controller;
        }

        public void AddInListView(IOrder menu, Drink drink, Pizza pizza)
        {
            ListViewItem item;
            item = menu.ToListViewItem(drink, pizza);
            listView1.Items.Add(item);
        }

        public void PrintCalculations(TotalPrice totalPrice, AveragePrice averagePrice, TotalQuantity totalQuantity)
        {
            txtPrezzoBevande.Text = totalPrice.GetTotalDrink().ToString();
            txtPrezzoPizze.Text = totalPrice.GetTotalPizze().ToString();
            txtPrezzoMenu.Text = totalPrice.GetTotalMenu().ToString();

            txtPrezzoMedioBevande.Text = averagePrice.ResultBevanda().ToString();
            txtPrezzoMedioPizze.Text = averagePrice.ResultPizza().ToString();
            txtPrezzoMedioMenu.Text = averagePrice.ResultMenu().ToString();

            txtQuantitaMenu.Text = totalQuantity.GetTotalMenu().ToString();
        }

        public void RemoveOnListView()
        {
            foreach (ListViewItem listItem in this.listView1.SelectedItems)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
        }

        public bool PrintReceipt(IOrder order, Client client)
        {
            bool confirm = false;

            if (MessageBox.Show(order.ReturnName() + "\n\n" + order.show() + client.show(), "CONFERMARE L'ORDINE ? ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (MessageBox.Show("GRAZIE PER AVER ACQUISTATO DA ALE PIZZA. \nIL SUO ORDINE VERRA' CONSEGNATO AL PIU' PRESTO", "ACQIUSTO CONFERMATO", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    confirm = true;
                }
            }

            return confirm;
        }

        public string ReturnNameMenuSelected()
        {
            if (this.listView1.SelectedItems.Count > 0)
                return this.listView1.SelectedItems[0].Text;
            else
                return "";
        }

        public void CloseProgramm()
        {
            Close();
        }

        public void ModifyOrder()
        {
            panel1.Enabled = true;
            panel2.Enabled = false;
            panel3.Enabled = true;
        }


        public string NamePizza => this.cmbPizza.Text;

        public string NameDrink => this.cmbBevanda.Text;

        public double PriceDrink => double.Parse(this.txtPrezzoBevanda.Text);


        public string NameClient => this.txtnome.Text;

        public string SurnameClient => this.txtcognome.Text;

        public string CityClient => txtcitta.Text;

        public string AddressClient => this.txtindirizzo.Text;

        public long TelefonClient => long.Parse(this.txtTelefono.Text);
    }
}
