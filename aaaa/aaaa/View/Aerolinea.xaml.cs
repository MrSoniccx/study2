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
    public partial class Aerolinea : ContentPage
    {
        AerolineaViewModel vm = new AerolineaViewModel();
        public Aerolinea()
        {
            InitializeComponent();
            BindingContext = vm;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            vm.GetAll();
        }
    }
}