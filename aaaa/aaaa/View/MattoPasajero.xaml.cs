using aaaa.Model;
using aaaa.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace aaaa.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MattoPasajero : ContentPage
    {
        public MattoPasajero(Pasajero pasajero)
        {
            InitializeComponent();
            BindingContext = new MattoPasajeroViewModel(pasajero);
        }
    }
}