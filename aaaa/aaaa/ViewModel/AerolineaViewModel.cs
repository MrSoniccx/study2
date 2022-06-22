using aaaa.Model;
using aaaa.Repositories;
using aaaa.View;
using Bogus;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace aaaa.ViewModel
{
    public class AerolineaViewModel : BaseViewModel
    {
        private PasajerosRepositorio PasajeroDb = new PasajerosRepositorio();
        private ObservableCollection<Pasajero> _Pasajeros;
        public ObservableCollection<Pasajero> Pasajeros {
            get { return _Pasajeros; }
            set { _Pasajeros = value; OnPropertyChanged(); }
            }

        public ICommand cmdAgregarPasajero { get; set; }

        public AerolineaViewModel()
        {
            cmdAgregarPasajero = new Command(() => cmdAgregarPasajeroMetodo());
        }
        
        private void cmdAgregarPasajeroMetodo()
        {
            Pasajero pasajero = new Faker<Pasajero>()
                .RuleFor(c => c.Name, f => f.Name.FirstName())
                .RuleFor(c => c.Apellido, f => f.Name.LastName());
            //.RuleFor(c => c.Email, (f, c) => f.Internet.Email(c.Name,c.Apellido)).Generate();
            //.RuleFor(c => c.Avatar, f=> f.Person.Avatar)
            App.Current.MainPage.Navigation.PushAsync(new MattoPasajero(pasajero));

            PasajeroDb.InsertOrUpdate(pasajero);

            App.Current.MainPage.Navigation.PopAsync();
            GetAll();

            
        }

        public void GetAll()
        {
            if (Pasajeros != null)
            {
                Pasajeros.Clear();
                PasajeroDb.GetAll().ForEach(item => Pasajeros.Add(item));
                Console.WriteLine(Pasajeros.Count);
            }
            else
            {
                Pasajeros = new ObservableCollection<Pasajero>(PasajeroDb.GetAll());
            }
            OnPropertyChanged();
        }

        public void Init()
        {
            PasajeroDb.Init();
        }


    }
}
