using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace InterfazRes
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Task.Run(RotateImage);
        }
        private async void RotateImage()
        {
            while (true)
            {
                await BannerImg.RelRotateTo(369, 40000, Easing.Linear);
            }
        }

        private async void platillos_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OrderPage());
        }


        private async void login_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Login());
        }

    }
}
