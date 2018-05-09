using System;
using System.Collections.Generic;
using System.Text;

namespace DataBindingApp
{
    using System.Collections.ObjectModel;
    public class Datos:Notificable
    {
        #region Atributos

        
        private ObservableCollection<Persona> personas;
        private Persona personaSeleccionada;
        #endregion

        #region Propiedades


        public Persona PersonaSeleccionada
        {
            get
            {
                return personaSeleccionada;
            }
            set
            {
                if (PersonaSeleccionada == value)
                {
                    return;
                }
                personaSeleccionada = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<Persona> Personas
        {
            get
            {
                return personas;
            }
            set
            {
                personas = value;
                OnPropertyChanged();
            }
        }
        #endregion

       

        #region Constructor
        public Datos()
        {
            personas = new ObservableCollection<Persona>();
            for (int i = 0; i < 5; i++)
            {
                personas.Add(new Persona()
                {
                    Nombre = $"Persona {i}",
                    Pais = $"Pais {i}"
                });
            }
        }
        #endregion
    }
}
