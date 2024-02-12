using System;
using System.Collections.ObjectModel;
using DDClothingStore.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DDClothingStore.View
{
    /// <summary>
    /// ContentPage representing the item list of a particular category
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemListPage : ContentPage
    {
        public ItemListPage(ObservableCollection<Item> items)
        {
            InitializeComponent();
            CategoryTitle.Text = items[0].Category.ToString();
            ItemsCollectionView.ItemsSource = items;
        }

        private async void OnBackButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
           
        }

        //ToDo
        private async void OnItemClick(object sender, EventArgs e)
        {
            await DisplayAlert ("Sorry", "This feature will be available soon", "OK");
        }
    }
}