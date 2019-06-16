using SQLite;
using StudioC.Models;
using StudioC.Services;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StudioC.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CadastroPage : ContentPage
    {

        private StudioCC studio;
        public CadastroPage(bool isEdit, StudioCC studio)
        {
            InitializeComponent();
           
            Cadastrar.IsVisible = !isEdit;
            if (studio != null)
            {
                this.studio = studio;
                nomeEntry.Text = studio.Nome;
                senhaEntry.Text = studio.Senha;
                telefoneEntry.Text = studio.Telefone;


            }

        }

        private void OnCadastrar(object sender, EventArgs e)
        {

            var studio = new StudioCC();
            studio.Nome = nomeEntry.Text;
            studio.Senha = senhaEntry.Text;
            studio.Telefone = telefoneEntry.Text;

            StudioCDAO dao = new StudioCDAO();
            dao.Adicionar(studio);


            Navigation.PopAsync();

            if (string.IsNullOrEmpty(nomeEntry.Text))
            {
                DisplayAlert("Erro", "É necessário digitar um nome", "OK");

                Navigation.PushAsync(new CadastroPage(false, null));

                return;
            }

            if (string.IsNullOrEmpty(senhaEntry.Text))
            {
                DisplayAlert("Erro", "É necessário digitar uma senha", "OK");

                Navigation.PushAsync(new CadastroPage(false, null));

                return;
            }

            if (string.IsNullOrEmpty(telefoneEntry.Text))
            {
                DisplayAlert("Erro", "É necessário digitar um telefone", "OK");

                Navigation.PushAsync(new CadastroPage(false,null));

                return;

             
            }

            

        }
        
        private void OnVoltar(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage(null));
        }
    }
           
  }
           
            