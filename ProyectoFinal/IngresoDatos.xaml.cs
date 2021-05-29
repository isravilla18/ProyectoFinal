using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoFinal
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IngresoDatos : ContentPage
    {
        public IngresoDatos()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text;
            String cedula = txtCedula.Text;
            String celular = txtCelular.Text;
            await Navigation.PushAsync(new Home(nombre,cedula,celular));
        }
    }
}