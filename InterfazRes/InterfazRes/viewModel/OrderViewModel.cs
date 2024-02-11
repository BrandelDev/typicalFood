using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace InterfazRes.viewModel
{
    public class OrderViewModel : BaseViewModel
    {
        public OrderViewModel()
        {
            MenuList = GetMenu();
        }
        public List<Pick> MenuList { get; set; }
        //public ICommand BackCommand => new Command(() => ApplicationException.Current.MainPage.Navigation.PopAsync());

        public List<Pick> GetMenu()
        {
            return new List<Pick>
            {
                new Pick{Title="Ajiaco", Image="Ajiaco.png", Description="Contiene sopa, papa, pollo y mazorca. Platillo típico de Colombia.", Price="25.000"},
                new Pick{Title="Ceviche", Image="ceviche.png", Description="Contiene pescado blanco, lima, cebolla roja, cilantro y sal. Típico de perú.", Price="40.000"},
                new Pick{Title="Sancocho", Image="sancocho2.png", Description="Contiene sopa, mazorca, carne de res y papa. Platillo típico de Colombia.", Price="15.000"},
                new Pick{Title="Bandeja paisa", Image="bandeja.png", Description="Contiene arroz, frijoles, aguacate y chicharron. Platillo típico de Colombia.", Price="20.000"},
                new Pick{Title="Taco al pastor", Image="taco2.png", Description="Contiene carne asada servida en tortillas de maiz. Platillo típico de mexico.", Price="35.000"}
            };
        }
    }
}
