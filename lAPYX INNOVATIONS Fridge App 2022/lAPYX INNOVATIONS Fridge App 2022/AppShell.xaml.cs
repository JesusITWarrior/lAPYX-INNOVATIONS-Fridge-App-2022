using lAPYX_INNOVATIONS_Fridge_App_2022.ViewModels;
using lAPYX_INNOVATIONS_Fridge_App_2022.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace lAPYX_INNOVATIONS_Fridge_App_2022
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
