using InterfazRes.modelo;
using InterfazRes.viewModel;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace InterfazRes.servicio
{
    public class PersonaServicio
    {


        SQLiteConnection connection;

        public string MensajeDeEstado { get; set; }

        public PersonaServicio()
        {
            connection = new SQLiteConnection(Constantes.DatabasePath, Constantes.flags);
            connection.CreateTable<PersonaModel>();

        }


        public void Guardar(PersonaModel nuevaPersona)
        {
            int result = 0;
            try
            {

                result = connection.Insert(nuevaPersona);
                MensajeDeEstado = String.Format($"{result} Registro(s) Agregados");

            }
            catch (Exception ex)
            {
                MensajeDeEstado = $"Error: {ex.Message}";


            }
        }
        public List<PersonaModel> SeleccionarTodo()
        {
            try
            {
                return connection.Table<PersonaModel>().ToList();

            }
            catch (Exception ex)
            {
                MensajeDeEstado = $"Error: {ex.Message}";


            }
            return null;
        }
        public PersonaModel Get(int id) {

            try
            {
                return connection.Table<PersonaModel>().FirstOrDefault(x => x.Id == id);

            }
            catch (Exception ex) {
                MensajeDeEstado = $"Error:{ex.Message}";
            }
            return null;
        
        
        }

        public void Modificar(PersonaModel nuevaPersona) { 
            
            int result = 0;

            try
            {
                if (nuevaPersona.Id != 0)
                {
                    result = connection.Update(nuevaPersona);
                    MensajeDeEstado = string.Format($"{result} Registro(s) Actualizado(s)");

                }
                else
                {

                    result = connection.Insert(nuevaPersona);
                    MensajeDeEstado = string.Format($"{result} Registro(s) Agregados(s)");

                }

            }
            catch (Exception ex) {

                MensajeDeEstado = $"Error:{ex.Message}";


            }
        
        }
        public void Eliminar(int idPersona)
        {
            try
            {
                var persona = Get(idPersona);
                connection.Delete(persona);


            }
            catch (Exception ex) {

                MensajeDeEstado = $"Error: {ex.Message}";
            
            }


        }



    }
}
