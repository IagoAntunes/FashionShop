using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LojaRoupas
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new View.Home();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
