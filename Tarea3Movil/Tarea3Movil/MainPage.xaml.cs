using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarea3Movil
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            var pagina1 = new Page1();
            await Navigation.PushAsync(pagina1);
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            ListaEmpleados.ItemsSource = await App.BaseDatos.listaempleados();
        }

        private async void ListaEmpleados_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Models.datosEmpleados item = (Models.datosEmpleados)e.Item;
            var newpage = new Page1();
            newpage.BindingContext = item;
            await Navigation.PushAsync(newpage);
        }


    }
}
