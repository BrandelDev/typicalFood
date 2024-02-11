using InterfazRes.viewModel;
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
    public partial class CrearCuenta : ContentPage
    {


        public CrearCuenta()
        {
            InitializeComponent();

            BindingContext = new PersonaViewModel();
        
        
        }


       

        private void pickerBanco_SelectedItemIndexChanged(object sender, EventArgs e)
        {
            if (banco.SelectedItem == "Otro")
            {
                otro.IsVisible = Convert.ToBoolean("True");
            }
            else
            {
                otro.IsVisible = Convert.ToBoolean("False");
            }
        }

        private async void home_clicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}