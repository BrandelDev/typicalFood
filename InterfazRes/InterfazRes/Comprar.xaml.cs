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
    public partial class Comprar : ContentPage
    {
        public Comprar()
        {
            InitializeComponent();
            NumPla.SelectedItem = "1";
            tipo.SelectedItem = "Crédito";
            banco.SelectedItem = "Bancolombia";
            NomPlato.Text = Datos.TituloGlo;
            DescPlato.Text = Datos.DescGlo;
            Precio.Text = Datos.precioGlo;
            BannerImg.Source = Datos.ImagenGlo;
            Task.Run(RotateImage);
        }

        private async void RotateImage()
        {
            while (true)
            {
                await BannerImg.RelRotateTo(369, 40000, Easing.Linear);
            }
        }
        private void pickerNum_SelectedItemIndexChanged(object sender, EventArgs e)
        {
            if(NumPla.SelectedItem == "1")
            {
                Tiempo.Text = "Tiempo de entrega max.: 30 Min.";
                PrecioTotal.Text = "Precio total: 25.000 pesos.";
            }else if(NumPla.SelectedItem == "2")
            {
                Tiempo.Text = "Tiempo de entrega max.: 1 hora.";
                PrecioTotal.Text = "Precio total: 50.000 pesos.";
            }
            else if (NumPla.SelectedItem == "3")
            {
                Tiempo.Text = "Tiempo de entrega max.: 1 hora 30 min.";
                PrecioTotal.Text = "Precio total: 75.000 pesos.";
            }
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

        private async void login_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Login());
        }

        private async void home_clicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}