using MVCController;
using MVCModal;
using System;
using System.Collections;

namespace WinFormMVC.Controller
{
    public class PizzeriaController
    {
        IOrder order = new Menu("ORDINE FINALE ");
        IOrder menu;
        Pizza pizza;
        Drink drink;
        Client client;

        private int numOrder;

        IVisitor totalPrice;
        IVisitor averagePrice;
        IVisitor totalQuantity;

        IPizzeriaView view;
        private IDatabase db;

        public PizzeriaController(IPizzeriaView _view, string database)
        {
            this.view = _view;

            view.SetController(this);
            numOrder = 0;
            totalPrice = new TotalPrice();
            averagePrice = new AveragePrice();
            totalQuantity = new TotalQuantity();
            db = DBHendler.GetInstance(database);
            client = new Client();
        }

        //AGGIUNGO MENU
        public void AddMenu()
        {

            pizza = Cooking(view.NamePizza);
            drink = new Drink(view.NameDrink, view.PriceDrink);

            menu = CreateMenu(pizza, drink);

            UpdateCalculation();

            view.AddInListView(menu, drink, pizza);
        }

        private void UpdateCalculation()
        {
            totalPrice.Reset();
            totalQuantity.Reset();
            averagePrice.Reset();

            foreach (IOrder component in order.ReturnMenu())
            {
                component.Accept(totalPrice);
                component.Accept(totalQuantity);
                component.Accept(averagePrice);

                foreach (IOrder product in component.ReturnMenu())
                {
                    product.Accept(totalPrice);
                    product.Accept(averagePrice);

                }
            }

            view.PrintCalculations(totalPrice, averagePrice, totalQuantity);
        }

        private Pizza Cooking(string nomePizza)
        {
            var director = new Cook(nomePizza);
            var builder = new ConcreteBuilder();

            director.Builder = builder;
            director.CreaPizza();

            return builder.GetProduct();
        }

        private IOrder CreateMenu(Pizza pizza, Drink drink)
        {
            numOrder++;
            IOrder menu = new Menu("MENU " + numOrder);
            menu.AddMenu(pizza);
            menu.AddMenu(drink);
            order.AddMenu(menu);

            return menu;
        }

        //RIMUOVO MENU

        public void RemoveMenu()
        {
            IOrder m;
            string nameMenu;

            nameMenu = view.ReturnNameMenuSelected();

            m = order.SearchMenu(nameMenu);
            order.RemoveMenu(m);

            view.RemoveOnListView();
            UpdateCalculation();
        }

        //STAMPA MENU

        public void ShowMenu()
        {
            IOrder m;
            string nameMenu;

            nameMenu = view.ReturnNameMenuSelected();
            m = order.SearchMenu(nameMenu);
            view.PrintMenu(m);

        }

        //CREO CLIENTE

        public void CreateClient()
        {
            client.Name = view.NameClient;
            client.Surname = view.SurnameClient;
            client.City = view.CityClient;
            client.Address = view.AddressClient;
            client.Telefon = view.TelefonClient;

            CreateReceipt();
        }

        private void CreateReceipt()
        {
            bool confirm;

            confirm = view.PrintReceipt(order, client);

            if (confirm == true)
            {
                db.SaveData(order, client);
                view.CloseProgramm();
            }
            else
            {
                view.ModifyOrder();
            }
        }
    }
}
