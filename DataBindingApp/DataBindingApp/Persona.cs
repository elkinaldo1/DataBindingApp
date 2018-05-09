using System;
using System.Collections.Generic;
using System.Text;


namespace DataBindingApp
{
    public class Persona : Notificable
    {
        #region Atributos

        public string nombre;
        public string pais;
        #endregion

        #region Propiedades

        public string Nombre {
            get
            {
                return nombre;
            }
            set
            {
                if (nombre == value)
                {
                    return;
                }
                nombre = value;
                OnPropertyChanged("Nombre");
            }
        }

        public string Pais
        {
            get
            {
                return pais;
            }
            set
            {
                if (pais == value)
                {
                    return;
                }
                pais = value;
                OnPropertyChanged("Pais");
            }
        }

        #endregion

        //#region Implementacion

        //public event PropertyChangedEventHandler PropertyChanged;
        //protected void OnPropertyChanged(string propertyName)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}
        //#endregion

        #region Metodos
        public override string ToString()
        {
            return $"{Nombre} | {Pais}";
        } 
        #endregion



    }
}
