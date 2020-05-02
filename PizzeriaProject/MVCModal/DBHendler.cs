using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MVCModal
{
    public class DBHendler : IDatabase
    {
        private readonly string DBPath;

        private static DBHendler instance;

        public static DBHendler GetInstance(string databaseFilePath)
        {
            if (instance == null)
            {
                instance = new DBHendler(databaseFilePath);
            }

            return instance;
        }

        protected DBHendler(string datafile)
        {
            DBPath = datafile;
        }

        public void SaveData(IOrder ordine, Client cliente)
        {
            JArray ordineArray = new JArray
            (
                (new JObject
                {
                    { "Nome ordine ", ordine.ReturnName() + "DI " + cliente.Name + " " + cliente.Surname },
                    {  "Prezzo ordine totale", ordine.ReturnPrice() },

                }),

                (new JObject
                {
                    {  "Nome", cliente.Name  },
                    {  "Cognome", cliente.Surname },
                    {  "Indirizzo", cliente.Address },
                    {  "Città", cliente.City  },
                    {  "Telefono", cliente.Telefon },

                }),

                ordine.ReturnMenu().Select(i => new JObject
                {
                    { "Nome menu", i.ReturnName() },
                    { "Descrizione", i.show() },
                    { "Prezzo", i.ReturnPrice() },
                })

            );

            File.WriteAllText(DBPath, File.ReadAllText(DBPath) + "\n\n" + ordineArray.ToString());

        }
    }
}
