using MauiGerenteDeEventos.Views;

namespace MauiGerenteDeEventos
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }
    }
}
