using CursoMaui.Pages;

namespace CursoMaui
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new FlyoutPageExample(); // Aquí se asignará nuestra FlyoutPage personalizada.
        }
    }
}
