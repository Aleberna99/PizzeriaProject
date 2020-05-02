using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Collections;
using  WinFormMVC.View;
using  WinFormMVC.Controller;


namespace UseMVCApplication
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            PizzeriaView view = new PizzeriaView();
            view.Visible = false;

            PizzeriaController controller = new PizzeriaController(view, @"C:\Users\Roberto\Desktop\PMO\PizzeriaProject\PizzeriaProject\db2.txt");

            view.ShowDialog();
        }
    }
}
