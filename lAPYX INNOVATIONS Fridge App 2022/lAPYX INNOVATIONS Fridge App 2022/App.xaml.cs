using lAPYX_INNOVATIONS_Fridge_App_2022.Services;
using lAPYX_INNOVATIONS_Fridge_App_2022.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lAPYX_INNOVATIONS_Fridge_App_2022
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
