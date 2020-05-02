using MVCController;
using MVCModal;
using System;

namespace WinFormMVC.Controller
{
    public interface IPizzeriaView
    {
        void SetController(PizzeriaController controller);
        void AddInListView(IOrder menu, Drink drink, Pizza pizza);
        void PrintCalculations(TotalPrice totalPrice, AveragePrice averagePrice, TotalQuantity totalQuantity);
        void RemoveOnListView();
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
