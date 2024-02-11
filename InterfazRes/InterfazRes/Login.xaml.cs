using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InterfazRes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void crearcuenta_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CrearCuenta());
        }
        private async void home_clicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
        private async void login_clicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}