using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StudioC.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class agradecimento : ContentPage
    {
        public agradecimento()
        {
            InitializeComponent();
        }

        private void OnInicio(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new MainPage(null));
        }
    }
}