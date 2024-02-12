using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using DDClothingStore.Model;
using DDClothingStore.View;
using Xamarin.Forms;

namespace DDClothingStore.ViewModel
{
    /// <summary>
    /// ViewModel for the home page.
    /// </summary>
    public class HomePageViewModel: INotifyPropertyChanged
    {
        // Collection of categories
        private readonly IList<Category> _categorySource;
        
        // Collection of items
        private readonly IList<Item> _itemSource;
        
        // Collection of categories to bind to UI
        public ObservableCollection<Category> Categories { get; private set; }
        
        // Collection of items to bind to UI
        public ObservableCollection<Item> Items { get; private set; }
        
        // Command to handle tapping on a category
        public ICommand CategoryTapCommand { get; set; }
        
        // Command to handle tapping on an item
        public ICommand ItemTapCommand { get; set; }
        public ICommand KidsFashionOfferTapCommand { get; set; }
        public HomePageViewModel()
        {
            _categorySource = new List<Category>();
            _itemSource = new List<Item>();
            PopulateCategoryCollection();
            PopulateItemCollection();
            
            CategoryTapCommand = new Command<Category>(category =>
            {
               Application.Current.MainPage.Navigation.PushModalAsync(new ItemListPage(GetItemsByCategory(category)));
            });

            KidsFashionOfferTapCommand = new Command<Category>(category =>
            {
                Application.Current.MainPage.Navigation.PushModalAsync(new ItemListPage(GetItemsByCategory(category)));
            });
            
            ItemTapCommand = new Command<Item>(items =>
            {
                //ToDo
                //string selected = items.ItemName;
                //Application.Current.MainPage.Navigation.PushModalAsync(new ItemListPage(selected));
            });
        }
        
        
        private void PopulateCategoryCollection()
        {
            _categorySource.Add(new Category
            {
                CategoryImage = "men",
                CategoryTitle = "Men",
                CategoryUrl = ""
            });
            _categorySource.Add(new Category
            {
                CategoryImage = "woman",
                CategoryTitle = "Women",
                CategoryUrl = ""
            });
            _categorySource.Add(new Category
            {
                CategoryImage = "kids",
                CategoryTitle = "Kids",
                CategoryUrl = ""
            });

            _categorySource.Add(new Category
            {
                CategoryImage = "baby",
                CategoryTitle = "Baby",
                CategoryUrl = ""
            });

            _categorySource.Add(new Category
            {
                CategoryImage = "sports",
                CategoryTitle = "Sportswear",
                CategoryUrl = ""
            });
            
            _categorySource.Add(new Category
            {
                CategoryImage = "winter",
                CategoryTitle = "Winterwear",
                CategoryUrl = ""
            });

            _categorySource.Add(new Category
            {
                CategoryImage = "swimwear",
                CategoryTitle = "Swimwear",
                CategoryUrl = ""
            });
            // Adding categories to the collection
            Categories = new ObservableCollection<Category>(_categorySource);
        }

        private void PopulateItemCollection()
        {
            _itemSource.Add(new Item
            {
                ItemName = "Men's T-shirt",
                ItemImage = "mens1",
                ItemPrice = "$ 10",
                Category = CategoryEnum.Men,
                ItemUrl = "",
                ItemDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                                  "Sed commodo mi et odio tristique efficitur. Phasellus sed pharetra erat. " +
                                  "Pellentesque consectetur hendrerit varius."
            });
            
            _itemSource.Add(new Item
            {
                ItemName = "Fashion men's windproof jacket",
                ItemImage = "mens2",
                ItemPrice = "$ 20",
                Category = CategoryEnum.Men,
                ItemUrl = "",
                ItemDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                                  "Sed commodo mi et odio tristique efficitur. Phasellus sed pharetra erat. " +
                                  "Pellentesque consectetur hendrerit varius."
            });
            
            _itemSource.Add(new Item
            {
                ItemName = "100% Cotton New Summer Men's T Shirt ",
                ItemImage = "mens3",
                ItemPrice = "$ 10",
                Category = CategoryEnum.Men,
                ItemUrl = "",
                ItemDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                                  "Sed commodo mi et odio tristique efficitur. Phasellus sed pharetra erat. " +
                                  "Pellentesque consectetur hendrerit varius."
            });
            
            _itemSource.Add(new Item
            {
                ItemName = "New Arrival Loose Comfy Cotton Pants",
                ItemImage = "mens4",
                ItemPrice = "$ 40",
                Category = CategoryEnum.Men,
                ItemUrl = "",
                ItemDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                                  "Sed commodo mi et odio tristique efficitur. Phasellus sed pharetra erat. " +
                                  "Pellentesque consectetur hendrerit varius."
            });
            
            _itemSource.Add(new Item
            {
                ItemName = "Women's Comfy T-shirt",
                ItemImage = "womens1",
                ItemPrice = "$ 10",
                Category = CategoryEnum.Women,
                ItemUrl = "",
                ItemDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                                  "Sed commodo mi et odio tristique efficitur. Phasellus sed pharetra erat. " +
                                  "Pellentesque consectetur hendrerit varius."
            });
            
            _itemSource.Add(new Item
            {
                ItemName = "Women's White T-shirt",
                ItemImage = "womens2",
                ItemPrice = "$ 20",
                Category = CategoryEnum.Women,
                ItemUrl = "",
                ItemDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                                  "Sed commodo mi et odio tristique efficitur. Phasellus sed pharetra erat. " +
                                  "Pellentesque consectetur hendrerit varius."
            });
            
            _itemSource.Add(new Item
            {
                ItemName = "Women's Printed T-shirt",
                ItemImage = "womens3",
                ItemPrice = "$ 20",
                Category = CategoryEnum.Women,
                ItemUrl = "",
                ItemDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                                  "Sed commodo mi et odio tristique efficitur. Phasellus sed pharetra erat. " +
                                  "Pellentesque consectetur hendrerit varius."
            });
            
            _itemSource.Add(new Item
            {
                ItemName = "Women's Orange T-shirt",
                ItemImage = "womens4",
                ItemPrice = "$ 10",
                Category = CategoryEnum.Women,
                ItemUrl = "",
                ItemDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                                  "Sed commodo mi et odio tristique efficitur. Phasellus sed pharetra erat. " +
                                  "Pellentesque consectetur hendrerit varius."
            });
            
            _itemSource.Add(new Item
            {
                ItemName = "Kid's T-shirt",
                ItemImage = "kids1",
                ItemPrice = "$ 10",
                Category = CategoryEnum.Kids,
                ItemUrl = "",
                ItemDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                                  "Sed commodo mi et odio tristique efficitur. Phasellus sed pharetra erat. " +
                                  "Pellentesque consectetur hendrerit varius."
            });
            
            _itemSource.Add(new Item
            {
                ItemName = "Kid's comfy pack",
                ItemImage = "kids2",
                ItemPrice = "$ 10",
                Category = CategoryEnum.Kids,
                ItemUrl = "",
                ItemDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                                  "Sed commodo mi et odio tristique efficitur. Phasellus sed pharetra erat. " +
                                  "Pellentesque consectetur hendrerit varius."
            });
            
            _itemSource.Add(new Item
            {
                ItemName = "Kid's fashion pack",
                ItemImage = "kids3",
                ItemPrice = "$ 20",
                Category = CategoryEnum.Kids,
                ItemUrl = "",
                ItemDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                                  "Sed commodo mi et odio tristique efficitur. Phasellus sed pharetra erat. " +
                                  "Pellentesque consectetur hendrerit varius."
            });
            
            _itemSource.Add(new Item
            {
                ItemName = "Kid's comfy jacket",
                ItemImage = "kids4",
                ItemPrice = "$ 30",
                Category = CategoryEnum.Kids,
                ItemUrl = "",
                ItemDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                                  "Sed commodo mi et odio tristique efficitur. Phasellus sed pharetra erat. " +
                                  "Pellentesque consectetur hendrerit varius."
            });
            
            _itemSource.Add(new Item
            {
                ItemName = "Newborn pack",
                ItemImage = "baby1",
                ItemPrice = "$ 30",
                Category = CategoryEnum.Baby,
                ItemUrl = "",
                ItemDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                                  "Sed commodo mi et odio tristique efficitur. Phasellus sed pharetra erat. " +
                                  "Pellentesque consectetur hendrerit varius."
            });
            
            _itemSource.Add(new Item
            {
                ItemName = "Baby shirt",
                ItemImage = "baby2",
                ItemPrice = "$ 10",
                Category = CategoryEnum.Baby,
                ItemUrl = "",
                ItemDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                                  "Sed commodo mi et odio tristique efficitur. Phasellus sed pharetra erat. " +
                                  "Pellentesque consectetur hendrerit varius."
            });
            
            _itemSource.Add(new Item
            {
                ItemName = "Knitted baby shirt",
                ItemImage = "baby3",
                ItemPrice = "$ 30",
                Category = CategoryEnum.Baby,
                ItemUrl = "",
                ItemDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                                  "Sed commodo mi et odio tristique efficitur. Phasellus sed pharetra erat. " +
                                  "Pellentesque consectetur hendrerit varius."
            });
            
            _itemSource.Add(new Item
            {
                ItemName = "Knitted pack",
                ItemImage = "baby4",
                ItemPrice = "$ 40",
                Category = CategoryEnum.Baby,
                ItemUrl = "",
                ItemDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                                  "Sed commodo mi et odio tristique efficitur. Phasellus sed pharetra erat. " +
                                  "Pellentesque consectetur hendrerit varius."
            });
            
            _itemSource.Add(new Item
            {
                ItemName = "Comfy short",
                ItemImage = "sports1",
                ItemPrice = "$ 10",
                Category = CategoryEnum.Sportswear,
                ItemUrl = "",
                ItemDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                                  "Sed commodo mi et odio tristique efficitur. Phasellus sed pharetra erat. " +
                                  "Pellentesque consectetur hendrerit varius."
            });
            
            _itemSource.Add(new Item
            {
                ItemName = "Women's sports kit",
                ItemImage = "sports2",
                ItemPrice = "$ 50",
                Category = CategoryEnum.Sportswear,
                ItemUrl = "",
                ItemDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                                  "Sed commodo mi et odio tristique efficitur. Phasellus sed pharetra erat. " +
                                  "Pellentesque consectetur hendrerit varius."
            });
            
            _itemSource.Add(new Item
            {
                ItemName = "Sport skinny",
                ItemImage = "sports3",
                ItemPrice = "$ 10",
                Category = CategoryEnum.Sportswear,
                ItemUrl = "",
                ItemDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                                  "Sed commodo mi et odio tristique efficitur. Phasellus sed pharetra erat. " +
                                  "Pellentesque consectetur hendrerit varius."
            });
            
            _itemSource.Add(new Item
            {
                ItemName = "Hooded winter Jacket",
                ItemImage = "winter1",
                ItemPrice = "$ 70",
                Category = CategoryEnum.Winterwear,
                ItemUrl = "",
                ItemDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                                  "Sed commodo mi et odio tristique efficitur. Phasellus sed pharetra erat. " +
                                  "Pellentesque consectetur hendrerit varius."
            });
            
            _itemSource.Add(new Item
            {
                ItemName = "Red winter Jacket",
                ItemImage = "winter2",
                ItemPrice = "$ 60",
                Category = CategoryEnum.Winterwear,
                ItemUrl = "",
                ItemDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                                  "Sed commodo mi et odio tristique efficitur. Phasellus sed pharetra erat. " +
                                  "Pellentesque consectetur hendrerit varius."
            });
            
            _itemSource.Add(new Item
            {
                ItemName = "Fashion Jacket",
                ItemImage = "winter3",
                ItemPrice = "$ 40",
                Category = CategoryEnum.Winterwear,
                ItemUrl = "",
                ItemDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                                  "Sed commodo mi et odio tristique efficitur. Phasellus sed pharetra erat. " +
                                  "Pellentesque consectetur hendrerit varius."
            });
            
            Items = new ObservableCollection<Item>(_itemSource);
        }

        private ObservableCollection<Item> GetItemsByCategory(Category category)
        {
            return new ObservableCollection<Item>(Items.Where(item => item.Category.ToString() == category.CategoryTitle));
        }
        
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}