using aaaa.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace aaaa.Repositories
{
    public class PasajerosRepositorio
    {
        SQLiteConnection connection;

        public PasajerosRepositorio()
        {
            connection = new SQLiteConnection(Constants.Constants.DatabasePath, Constants.Constants.Flags);
            connection.CreateTable<Pasajero>();

        }

        public void Init()
        {
            connection.CreateTable<Pasajero>();
            AddFromStart("Jochue Benja", "Jamonero");
            AddFromStart("Juempoblo Jamones", "wempo");
            AddFromStart("Mario Alex", "Wiener");
            AddFromStart("Wis Edgardo", "wis");
            AddFromStart("Ivon Jardines", "CryptoBro");
            AddFromStart("Hector Bonifacio", "Arroyero");
            AddFromStart("Edgar Rojas", "Cupsk");
            AddFromStart("Silvio Carmona", "Chuyo");
            AddFromStart("Andrea Almendros", "Andry");
            AddFromStart("Kevin Ornelas", "Orneli");

        }

        private void AddFromStart(string name, string apellido)
        {
            Pasajero pasagner = GetByName(name);

            if (pasagner == null)
            {
                InsertOrUpdate(new Pasajero() { Name = name, Apellido = apellido });
            }

        }

        public void InsertOrUpdate(Pasajero pasagner)
        {
            if (pasagner.Id == 0)
            {
                connection.Insert(pasagner);
            }
            else
            {
                connection.Update(pasagner);
            }
        }

        public Pasajero GetById(int Id)
        {
            return connection.Table<Pasajero>().FirstOrDefault(item => item.Id == Id);
            //return connection.GetAllWithChildren<Contacto>(item => item.Id == Id).FirstOrDefault();
        }

        public Pasajero GetByName(string Name)
        {
            return connection.Table<Pasajero>().FirstOrDefault(item => item.Name == Name);
        }

        public List<Pasajero> GetAll()
        {

            return connection.Table<Pasajero>().ToList();
        }

        public void DeleteItem(int Id)
        {
            Pasajero actor = GetById(Id);
            connection.Delete(actor);
        }
    



    }
}
