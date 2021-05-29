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
    public partial class Resumen : ContentPage
    {
        public Resumen(String nombrer, String cedular, String celularr)
        {
            InitializeComponent();
            lblUsuario1.Text = nombrer;
            lblnombre.Text = cedular;
            lblpagar.Text = celularr;
        }
    }
}