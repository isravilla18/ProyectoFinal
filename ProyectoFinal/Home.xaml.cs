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
    public partial class Home : ContentPage
    {
        public Home(String email, String ceduala, String Celular)
        {
            InitializeComponent();
            email = lblnombre.Text;
            ceduala = lblcedula.Text;
            Celular = lblcelular.Text;

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Lista elemento = new Lista();
            ListaElementos1.ItemsSource = elemento.elementos;
            ListaElementos1.ItemSelected += ListaElementos1_ItemSelected;
        }

        private async void ListaElementos1_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            String nombre1=lblnombre.Text;
            String cedula1=lblcedula.Text;
            String celular1 = lblcelular.Text;
            if (e.SelectedItem!=null) {
                var element = e.SelectedItem as Elemento;
                await DisplayAlert("Listas", element.Nombre, "Aceptar");
                await Navigation.PushAsync(new Resumen(nombre1,cedula1,celular1));

            }
        }
    }
}