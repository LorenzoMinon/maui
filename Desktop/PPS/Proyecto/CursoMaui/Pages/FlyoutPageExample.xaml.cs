using System;
using Microsoft.Maui.Controls;
using CursoMaui.Data;

namespace CursoMaui.Pages
{
    public partial class FlyoutPageExample : FlyoutPage
    {
        public FlyoutPageExample()
        {
            InitializeComponent();
        }

        public Command FlyoutOpenCommand => new Command(() => IsPresented = true);

        private void OnMenuItemSelected(object sender, SelectionChangedEventArgs e)
        {
            var item = e.CurrentSelection.FirstOrDefault() as FlyoutPageItem;
            if (item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                IsPresented = false;
            }
        }
    }
}
