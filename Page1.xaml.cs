using StudioC.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StudioC
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();

            Lista.ItemsSource = new List<Model>
            {
                new Model { Nome = "Corte", Preco = 50 },
                new Model { Nome = "Pintura", Preco = 90 },
                new Model { Nome = "Progressiva", Preco = 150 },
            };
        }


        private void OnSelecionar(object sender, EventArgs e)
        {
            Navigation.PushAsync(new escolha());
        }


        private async void OnCancelar(object sender, EventArgs e)
        {
            var action = await DisplayAlert("SAIR", "Tem certeza que deseja cancelar o pedido?", "Sim", "Não");
            if (action)
            {
                _ = Navigation.PushAsync(new MainPage(null));
            }

        }
    }
}