using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVCController
{
    class Cook
    {
        private IBuilder builder;
        public string tipePizza;
        public IBuilder Builder
        {
            set
            {
                builder = value;
            }
        }

        public Cook(string tipepizza)
        {
            this.tipePizza = tipepizza;
        }

        public void CreaPizza()
        {
            if (tipePizza == "MARGHERITA")
            {
                builder.SetName("PIZZA MARGHERITA");
                builder.AddIngredient("Pomodoro");
                builder.AddIngredient("Mozzarella");
                builder.SetPrice(6.00);
            }

            if (tipePizza == "ROSMARINO")
            {
                builder.SetName("PIZZA ROSMARINO");
                builder.AddIngredient("Rosmarino");
                builder.SetPrice(5.00);
            }

            if (tipePizza == "MARINARA")
            {
                builder.SetName("PIZZA MARINARA");
                builder.AddIngredient("Pomodoro");
                builder.AddIngredient("Origano");
                builder.AddIngredient("Aglio");
                builder.SetPrice(6.00);
            }

            if (tipePizza == "NAPOLI")
            {
                builder.SetName("PIZZA NAPOLI");
                builder.AddIngredient("Pomodoro");
                builder.AddIngredient("Capperi");
                builder.AddIngredient("Aglio");
                builder.AddIngredient("Acciughe");
                builder.SetPrice(6.50);
            }

            if (tipePizza == "PROSCIUTTO")
            {
                builder.SetName("PIZZA PROSCIUTTO");
                builder.AddIngredient("Mozzarella");
                builder.AddIngredient("Prociutto cotto");
                builder.SetPrice(7.00);
            }

            if (tipePizza == "PROSCIUTTO E FUNGHI")
            {
                builder.SetName("PIZZA PROSCIUTTO E FUNGHI");
                builder.AddIngredient("Mozzarella");
                builder.AddIngredient("Prosciutto cotto");
                builder.AddIngredient("Funghi");
                builder.SetPrice(7.50);
            }

            if (tipePizza == "PROSCIUTTO E TONNO")
            {
                builder.SetName("PIZZA PROCIUTTO E TONNO");
                builder.AddIngredient("Pomodoro");
                builder.AddIngredient("Prosciutto cotto");
                builder.AddIngredient("Tonno");
                builder.SetPrice(7.50);
            }

            if (tipePizza == "4 STAGIONI")
            {
                builder.SetName("PIZZA 4 STAGIONI");
                builder.AddIngredient("Mozzarella");
                builder.AddIngredient("Pomodoro");
                builder.AddIngredient("Funghi");
                builder.AddIngredient("Prosciutto cotto");
                builder.AddIngredient("Carciofini");
                builder.AddIngredient("Salame");
                builder.SetPrice(8.00);
            }

            if (tipePizza == "4 FORMAGGI")
            {
                builder.SetName("PIZZA 4 FORMAGGI");
                builder.AddIngredient("Mozzarella");
                builder.AddIngredient("Formaggio latteria");
                builder.AddIngredient("Emmenthal");
                builder.AddIngredient("Gorgonzola");
                builder.SetPrice(8.00);
            }

            if (tipePizza == "CAPRICCIOSA")
            {
                builder.SetName("PIZZA CAPRICCIOSA");
                builder.AddIngredient("Pomodoro");
                builder.AddIngredient("Prosciutto cotto");
                builder.AddIngredient("Mozzarella");
                builder.AddIngredient("Funghi");
                builder.AddIngredient("Carciofini");
                builder.SetPrice(7.00);
            }

            if (tipePizza == "DIAVOLA")
            {
                builder.SetName("PIZZA DIAVOLA");
                builder.AddIngredient("Mozzarella");
                builder.AddIngredient("Pomodoro");
                builder.AddIngredient("Salame Piccante");
                builder.SetPrice(7.50);
            }

            if (tipePizza == "SALSICCIA")
            {
                builder.SetName("PIZZA SALSICCIA");
                builder.AddIngredient("Mozzarella");
                builder.AddIngredient("Pomodoro");
                builder.AddIngredient("Salsiccia");
                builder.SetPrice(7.00);
            }

            if (tipePizza == "ROMANA")
            {
                builder.SetName("PIZZA ROMANA");
                builder.AddIngredient("Mozzarella");
                builder.AddIngredient("Pomodoro");
                builder.AddIngredient("Acciughe");
                builder.SetPrice(7.50);
            }

            if (tipePizza == "FUNGHI")
            {
                builder.SetName("PIZZA FUNGHI");
                builder.AddIngredient("Mozzarella");
                builder.AddIngredient("Pomodoro");
                builder.AddIngredient("Funghi");
                builder.SetPrice(7.00);
            }

            if (tipePizza == "CARCIOFINI")
            {
                builder.SetName("PIZZA CARCIOFINI");
                builder.AddIngredient("Mozzarella");
                builder.AddIngredient("Carciofini");
                builder.SetPrice(7.00);
            }

            if (tipePizza == "PEPERONI")
            {
                builder.SetName("PIZZA PEPERONI");
                builder.AddIngredient("Pomodoro");
                builder.AddIngredient("Peperoni");
                builder.SetPrice(7.00);
            }

            if (tipePizza == "OLIVE")
            {
                builder.SetName("PIZZA OLIVE");
                builder.AddIngredient("Pomodoro");
                builder.AddIngredient("Olive");
                builder.SetPrice(7.50);
            }

            if (tipePizza == "PUGLIESE")
            {
                builder.SetName("PIZZA PUGLIESE");
                builder.AddIngredient("Pomodoro");
                builder.AddIngredient("Mozzarella");
                builder.AddIngredient("Cipolla");
                builder.SetPrice(8.00);
            }

            if (tipePizza == "TONNO")
            {
                builder.SetName("PIZZA TONNO");
                builder.AddIngredient("Pomodoro");
                builder.AddIngredient("Tonno");
                builder.AddIngredient("Cipolla");
                builder.SetPrice(7.50);
            }

            if (tipePizza == "WURSTEL")
            {
                builder.SetName("PIZZA WURSTEL");
                builder.AddIngredient("Pomodoro");
                builder.AddIngredient("Mozzarella");
                builder.AddIngredient("Wurstel");
                builder.SetPrice(7.00);
            }

            if (tipePizza == "PATATE")
            {
                builder.SetName("PIZZA PATATE");
                builder.AddIngredient("Pomodoro");
                builder.AddIngredient("Mozzarella");
                builder.AddIngredient("Patate");
                builder.SetPrice(7.00);
            }

        }
    }
}
