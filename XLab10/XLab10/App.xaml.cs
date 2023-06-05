using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XLab10
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new BindingModeDemo();
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
