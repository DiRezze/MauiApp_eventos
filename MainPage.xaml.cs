using MauiGerenteDeEventos.Views;
using Microsoft.Maui.ApplicationModel.DataTransfer;

namespace MauiGerenteDeEventos
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new CadastroEventos());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Ok");
            }
        }
    }

}
