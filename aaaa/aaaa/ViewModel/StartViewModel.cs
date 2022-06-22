using aaaa.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace aaaa.ViewModel
{
    public class StartViewModel : BaseViewModel
    {
        public ObservableCollection<Numero> Numeros { get; set; }

        private Numero numero;

        public Numero Numero
        {
            get { return numero; }
            set { numero = value; OnPropertyChanged(); }
        }
       
        
        public ICommand cmdResta { get; set; }
        public ICommand cmdSuma { get; set; }

        public StartViewModel(){
            Numeros = new ObservableCollection<Numero>();


            for (int i = 0; i < 10; i++)
            {
                Numeros.Add(new Numero()
                {
                    id=i,
                    numba = new Random().Next(0, 10)
                });
            }

            cmdResta = new Command<Numero>(async (x) => await PCmdResta(x));
            cmdSuma = new Command<Numero>(async (x) => await PCmdSuma(x));

            async Task PCmdResta(Model.Numero _Numero)
            {
                _Numero.numba = _Numero.numba - 1;
                Numeros[_Numero.id].numba = _Numero.numba;
                Debug.WriteLine(_Numero.numba);
                OnPropertyChanged();
            }

            async Task PCmdSuma(Model.Numero _Numero)
            {
                _Numero.numba = _Numero.numba + 1;
                Numeros[_Numero.id].numba = _Numero.numba;
                Debug.WriteLine(_Numero.numba);
                OnPropertyChanged();
            }
        }
    }
}
