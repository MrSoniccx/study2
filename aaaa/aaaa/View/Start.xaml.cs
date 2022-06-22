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
    public partial class Start : ContentPage
    {
        public Start()
        {
            InitializeComponent();
        }

        private void Pagina1(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushAsync(new View.Interfaz());
        }
        private void Pagina2(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushAsync(new View.Triggers());
        }
        private void Pagina3(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushAsync(new View.SumaResta());
        }
        private void Pagina4(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushAsync(new View.Aerolinea());
        }
    }
}