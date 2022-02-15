using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Tarea3Movil.Models;


namespace Tarea3Movil
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private async void btnAgregar_Clicked(object sender, EventArgs e)
        {
            var emple = new datosEmpleados
            {
                nombres = Nombres.Text,
                apellidos = Apellidos.Text,
                edad = Convert.ToInt32(Edad.Text),
                correo = correo.Text,
                direccion = direccion.Text
            };
            var resultado = await App.BaseDatos.EmpleadoGuardar(emple);
            if (resultado != 0)
            {
                await DisplayAlert("Aviso", "Empleado ingresado con exito!!", "OK");
            }
            else
            {
                await DisplayAlert("Aviso", "Error!!", "OK");
            }
            await Navigation.PopAsync();
        }

        private async void btnActualizar_Clicked(object sender, EventArgs e)
        {
            var emple = new datosEmpleados
            {
                codigo = Convert.ToInt32(Codigo.Text),
                nombres = Nombres.Text,
                apellidos = Apellidos.Text,
                edad = Convert.ToInt32(Edad.Text),
                correo = correo.Text,
                direccion = direccion.Text
            };
            var resultado = await App.BaseDatos.EmpleadoGuardar(emple);
            if (resultado != 0)
            {
                await DisplayAlert("Aviso", "Empleado actualizado con exito!!", "OK");
            }
            else
            {
                await DisplayAlert("Aviso", "Error!!", "OK");
            }
            await Navigation.PopAsync();

        }

        private async void btnBorrar_Clicked(object sender, EventArgs e)
        {
            var emple = new datosEmpleados
            {
                codigo = Convert.ToInt32(Codigo.Text)
            };
            var resultado = await App.BaseDatos.EmpleadoBorrar(emple);
            if (resultado != 0)
            {
                await DisplayAlert("Aviso", "Empleado borrado con exito!!", "OK");
            }
            else
            {
                await DisplayAlert("Aviso", "Error!!", "OK");
            }
            await Navigation.PopAsync();
        }

    }
}