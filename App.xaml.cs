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

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Height = 640;
            window.Width = 580;

            window.Title = "MauiApp Gerente de Eventos";

            return window;
        }
    }
}
