using Microsoft.Maui.Controls;

namespace Eco_Ciencia
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}