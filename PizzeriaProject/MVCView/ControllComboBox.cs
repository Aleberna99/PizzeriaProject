using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MVCView
{
    public class ControllComboBox
    {
        private ComboBox cmbDrink;
        private ComboBox cmbPizza;
        private string ingredients;

        public ControllComboBox(ComboBox drink, ComboBox pizza)
        {
            this.cmbDrink = drink;
            this.cmbPizza = pizza;
        }

        public double ControllPriceDrink()
        {
            double prezzo = 0.00;

            if (cmbDrink.Text == "ACQUA 0,33 L")
            {
                prezzo = 2.00;
            }
            if (cmbDrink.Text == "THE' 0,33 L")
            {
                prezzo = 3.00;
            }
            if (cmbDrink.Text == "FANTA 0,33 L")
            {
                prezzo = 2.50;
            }
            if (cmbDrink.Text == "COCA COLA 0,33 L")
            {
                prezzo = 2.50;
            }
            if (cmbDrink.Text == "BIRRA 0,66 L")
            {
                prezzo = 4.00;
            }
            if (cmbDrink.Text == "BIRRA 0,33 L")
            {
                prezzo = 3.50;
            }
            if (cmbDrink.Text == "ACQUA 1 L")
            {
                prezzo = 3.00;
            }

            return prezzo;
        }

        public double ControllPricePizza()
        {
            double prezzo = 0.0;

            if (cmbPizza.Text == "ROSMARINO")
            {
                prezzo = 5.00;
            }
            if (cmbPizza.Text == "MARGHERITA")
            {
                prezzo = 6.00;
            }
            if (cmbPizza.Text == "MARINARA")
            {
                prezzo = 6.00;
            }
            if (cmbPizza.Text == "NAPOLI")
            {
                prezzo = 6.50;
            }
            if (cmbPizza.Text == "PROSCIUTTO")
            {
                prezzo = 7.00;
            }
            if (cmbPizza.Text == "PROSCIUTTO E FUNGHI")
            {
                prezzo = 7.50;
            }
            if (cmbPizza.Text == "PROSCIUTTO E TONNO")
            {
                prezzo = 7.50;
            }
            if (cmbPizza.Text == "4 STAGIONI")
            {
                prezzo = 8.00;
            }
            if (cmbPizza.Text == "4 FORMAGGI")
            {
                prezzo = 8.00;
            }
            if (cmbPizza.Text == "CAPRICCIOSA")
            {
                prezzo = 7.00;
            }
            if (cmbPizza.Text == "DIAVOLA")
            {
                prezzo = 7.50;
            }
            if (cmbPizza.Text == "SALSICCIA")
            {
                prezzo = 7.00;
            }
            if (cmbPizza.Text == "ROMANA")
            {
                prezzo = 7.50;
            }
            if (cmbPizza.Text == "FUNGHI")
            {
                prezzo = 7.00;
            }
            if (cmbPizza.Text == "CARCIOFINI")
            {
                prezzo = 7.00;
            }
            if (cmbPizza.Text == "PEPERONI")
            {
                prezzo = 7.00;
            }
            if (cmbPizza.Text == "OLIVE")
            {
                prezzo = 7.50;
            }
            if (cmbPizza.Text == "PUGLIESE")
            {
                prezzo = 8.00;
            }
            if (cmbPizza.Text == "TONNO")
            {
                prezzo = 7.50;
            }
            if (cmbPizza.Text == "WURSTEL")
            {
                prezzo = 7.00;
            }
            if (cmbPizza.Text == "PATATE")
            {
                prezzo = 7.00;
            }

            return prezzo;
        }

        public string ControllIngredient()
        {
            if (cmbPizza.Text == "ROSMARINO")
            {
                ingredients = "Rosmarino";
            }
            if (cmbPizza.Text == "MARGHERITA")
            {
                ingredients = "Pommodoro, Mozzarella";
            }
            if (cmbPizza.Text == "MARINARA")
            {
                ingredients = "Pomodoro, Origano, Aglio";
            }
            if (cmbPizza.Text == "NAPOLI")
            {
                ingredients = "Pomodoro, Capperi, Aglio, Acciughe";
            }
            if (cmbPizza.Text == "PROSCIUTTO")
            {
                ingredients = "Mozzarella, Prosciutto Cotto";
            }
            if (cmbPizza.Text == "PROSCIUTTO E FUNGHI")
            {
                ingredients = "Mozzarella, Prosciutto cotto, Funghi";
            }
            if (cmbPizza.Text == "PROSCIUTTO E TONNO")
            {
                ingredients = "Pomodoro, Prosciutto Cotto, Tonno";
            }
            if (cmbPizza.Text == "4 STAGIONI")
            {
                ingredients = "Mozzarella,Pomodoro,Funghi,Prosciutto cotto,Carciofini,Salame";
            }
            if (cmbPizza.Text == "4 FORMAGGI")
            {
                ingredients = "Mozzarella, Formaggio latteria, Emmenthal, Gorgonzola";
            }
            if (cmbPizza.Text == "CAPRICCIOSA")
            {
                ingredients = "Pomodoro, Prosciutto cotto, Mozzarella, Funghi, Carciofini";
            }
            if (cmbPizza.Text == "DIAVOLA")
            {
                ingredients = "Mozzarella, Pomodoro, Salame piccante";
            }
            if (cmbPizza.Text == "SALSICCIA")
            {
                ingredients = "Mozzarella, Pomodoro, Salsiccia";
            }
            if (cmbPizza.Text == "ROMANA")
            {
                ingredients = "Pomodoro, Mozzarella, Acciughe";
            }
            if (cmbPizza.Text == "FUNGHI")
            {
                ingredients = "Mozzarella, Pomodoro, Funghi";
            }
            if (cmbPizza.Text == "CARCIOFINI")
            {
                ingredients = "Mozzarella, Carciofini";
            }
            if (cmbPizza.Text == "PEPERONI")
            {
                ingredients = "Pomodoro, Peperoni";
            }
            if (cmbPizza.Text == "OLIVE")
            {
                ingredients = "Pomodoro, Olive";
            }
            if (cmbPizza.Text == "PUGLIESE")
            {
                ingredients = "Pomodoro, Mozzarella, Cipolle";
            }
            if (cmbPizza.Text == "TONNO")
            {
                ingredients = "Pomodoro, Tonno, Cipolle";
            }
            if (cmbPizza.Text == "WURSTEL")
            {
                ingredients = "Pomodoro, Mozzarella, Wurstel";
            }
            if (cmbPizza.Text == "PATATE")
            {
                ingredients = "Pomodoro, Mozzarella, Patate";
            }

            return ingredients;
        }

        public void ResetComboBox()
        {
            cmbDrink.Text = "";
            cmbPizza.Text = "";
        }
    }
}
