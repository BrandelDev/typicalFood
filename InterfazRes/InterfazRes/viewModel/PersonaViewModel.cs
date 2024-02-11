using Bogus;
using InterfazRes.modelo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace InterfazRes.viewModel
{
    public class PersonaViewModel : PersonaModel
    {
        public List<PersonaModel> personas { get; set; }
        public ICommand GuardarCommand { get; set; }

        public ICommand ModificarCommand { get; set; }

        public ICommand EliminarCommand { get; set; }

        public ICommand LimpiarCommand { get; set; }

        public PersonaModel NuevaPersona { get; set; }

        public PersonaViewModel() {

            Refresh();
            GenerarNuevaPersona();
            GuardarCommand = new Command(async () => { 
                App.PersonaServicio.Guardar(NuevaPersona);
                Console.WriteLine(App.PersonaServicio.MensajeDeEstado);
                GenerarNuevaPersona();
                Refresh();
            
            });
            ModificarCommand = new Command(async () =>
            {

                App.PersonaServicio.Modificar(NuevaPersona);
                Console.WriteLine(App.PersonaServicio.MensajeDeEstado);
                GenerarNuevaPersona();
                Refresh();

            });
            EliminarCommand = new Command(async (personas) => {

                App.PersonaServicio.Eliminar(((PersonaModel)personas).Id);
                Refresh();
            
            });
        
        
        }

        private void GenerarNuevaPersona() {
        
        NuevaPersona = new Faker<PersonaModel>()
                .RuleFor(x => x.Nombre, f=> f.Person.FirstName)
                .RuleFor(x => x.Correo, f=> f.Person.Email)
                .RuleFor(x => x.Direccion, f=> f.Person.UserName)
                .RuleFor(x => x.Municipio, f=> f.Person.LastName)
                .RuleFor(x => x.numeroCuentaBanco, f=> f.Person.Phone)
                
                .Generate();
        
        }


        private void Refresh() {

            personas = App.PersonaServicio.SeleccionarTodo();

        
        }



    }
}
