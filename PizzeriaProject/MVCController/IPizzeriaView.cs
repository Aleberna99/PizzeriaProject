﻿using MVCController;
using MVCModal;
using System;

namespace WinFormMVC.Controller
{
    public interface IPizzeriaView
    {
        void SetController(PizzeriaController controller);
        void AddInListView(IOrder menu, Drink drink, Pizza pizza);
        void PrintCalculations(IVisitor totalPrice, IVisitor averagePrice, IVisitor totalQuantity);
        void RemoveOnListView();
        void PrintMenu(IOrder menu);
        bool PrintReceipt(IOrder ordine, Client cliente);
        string ReturnNameMenuSelected();
        void CloseProgramm();
        void ModifyOrder();

        string NamePizza { get; }
        string NameDrink { get; }
        double PriceDrink { get; }

        string NameClient { get; }
        string SurnameClient { get; }
        string CityClient { get; }
        string AddressClient { get; }
        long TelefonClient { get; }

    }
}
