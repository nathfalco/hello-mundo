
using System;
using System.IO;
using SQLite;
using StudioC.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StudioC.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        private StudioCC studio;
        public MainPage(StudioCC studio)
        {
            InitializeComponent();
            
                if (studio != null)
            {
                this.studio = studio;
                nomeEntry.Text = studio.Nome;
                senhaEntry.Text = studio.Senha;
            }
        }
        private void OnLogar(object sender, EventArgs e)
        {
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "Usuario.db3");
            var db = new SQLiteConnection(dbPath);
            var dados = db.Table<StudioCC>(); //Chama tabela
            var login = dados.Where(x => x.Nome == nomeEntry.Text && x.Senha == senhaEntry.Text).FirstOrDefault();
            if(login != null)
            {
                
                Navigation.PushAsync(new Page1());
            }
            else
            {
                DisplayAlert("Erro", "É necessário efetuar um cadastro", "OK");
                return;

            }

            }
            

        private void OnCadastrarN(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CadastroPage(false,null));
        }
    }
}
