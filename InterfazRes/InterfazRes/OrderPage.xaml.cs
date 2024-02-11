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
    public partial class OrderPage : ContentPage
    {
        public OrderPage()
        {
            InitializeComponent();
            
        }
        private void CarouselPositionChanged(object sender, PositionChangedEventArgs e)
        {
            var carousel = sender as CarouselView;
            var views = carousel.VisibleViews;

            if (views.Count > 0)
            {
                foreach (var view in views)
                {
                    var img = view.FindByName<Image>("MenuImg");
                    ViewExtensions.CancelAnimations(img);
                    Task.Run(async () => await img.RelRotateTo(360, 5000, Easing.BounceOut));
                }
            }
        }

        private async void comprar_clicked(object sender, EventArgs e)
        {
            Datos.TituloGlo = "Ajiaco";
            Datos.DescGlo = "Descripción: Contiene sopa, papa, pollo y mazorca. Platillo típico de Colombia.";
            Datos.precioGlo = "Precio: 25.000 pesos";
            Datos.ImagenGlo = "Ajiaco.png";
            await Navigation.PushAsync(new Comprar());
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