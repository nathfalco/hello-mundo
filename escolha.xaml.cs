using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StudioC.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class escolha : ContentPage
    {
        public escolha()
        {
            InitializeComponent();
        }
        private async void OnMail(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(deEntry.Text))
            {
                _ = DisplayAlert("Erro", "É necessário digitar um nome ou E-Mail", "OK");
                return;
            }

            if (string.IsNullOrEmpty(paraEntry.Text))
            {
                _ = DisplayAlert("Erro", "É necessário digitar um E-Mail", "OK");
                return;
            }

            if (string.IsNullOrEmpty(assuntoEntry.Text))
            {
                _ = DisplayAlert("Erro", "É necessário digitar um assunto", "OK");
                return;
            }

            else
            {
                bool action = await DisplayAlert("Concluido", "O E-Mail foi enviado.", "Sim", "Não");
                if (action)
                {
                    _ = Navigation.PushAsync(new agradecimento());
                }
            }
        }

        private void OnVoltar(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page1());
        }
    }
}