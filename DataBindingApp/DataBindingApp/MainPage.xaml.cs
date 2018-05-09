using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DataBindingApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            botonEnviar.Clicked += BotonEnviar_Clicked;

        }

        private void BotonEnviar_Clicked(object sender, EventArgs e)
        {
            var per = (Persona)Resources["personaUno"];
            per.Nombre = "Neymar";
            per.Pais = "Brasil";
        }
    }
}
