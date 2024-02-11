using InterfazRes.servicio;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InterfazRes
{
    public partial class App : Application
    {

        public static PersonaServicio personaServicio;

        public static PersonaServicio PersonaServicio {
            get {
                if (personaServicio == null) { 
                    personaServicio = new PersonaServicio();
                
                }
                return personaServicio;
            
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage()) { 
                BarBackgroundColor = Color.FromHex("#6d5bbd"),
                BarTextColor = Color.Black,
            
            };
            
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
