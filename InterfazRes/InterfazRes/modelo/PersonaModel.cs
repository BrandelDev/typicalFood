using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace InterfazRes.modelo
{
    public class PersonaModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string nombre = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));
        }
        private bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy; }
            set
            {
                isBusy = value;
                OnPropertyChanged();
            }
        }
        private int id;
        [PrimaryKey, AutoIncrement]
        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged();
            }
        }
        private string nombreCompleto;
        public string Nombre
        {
            get { return nombreCompleto; }
            set
            {
                nombreCompleto = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(nombreCompleto));
            }
        }
        private string correo;

        public string Correo 
        {
            get { return correo; }
            set 
            {
                correo = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(correo));
               
            }
        }
        private string contrasena;
        public string Contrasena
        {
            get { return contrasena; }
            set 
            {
                contrasena = value;
                OnPropertyChanged();
            }
        
        
        }

        private string municipio;

        public string Municipio
        {
            get { return municipio; }
            set 
            {
                municipio = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(municipio));
            }
        }

        public string direccion;
        
        public string Direccion
        {
            get { return direccion; }
            set 
            { 
                direccion = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(direccion));
            }
        
        }
        public string tarjetaBancaria;
        public string TarjetaBancaria
        {
            get { return tarjetaBancaria; }
            set 
            {
                tarjetaBancaria = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(tarjetaBancaria));
            
            }
        
        }
        public string banco;
        public string Banco
        {
            get { return banco; }
            set 
            { 
                
                banco = value;
                OnPropertyChanged();
            }
        
        }

        public string numeroCuentaBanco;

        public string NumeroCuentaBanco {
            get { return numeroCuentaBanco; }

            set
            {
                numeroCuentaBanco = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(numeroCuentaBanco));
            }
        
        
        }
       

    }
}
