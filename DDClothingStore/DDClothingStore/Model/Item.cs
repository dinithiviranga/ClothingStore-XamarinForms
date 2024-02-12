using System;

namespace DDClothingStore.Model
{
    /// <summary>
    /// Model class representing an item.
    /// </summary>
    public class Item
    {
        public string ItemName
        {
            get; set;
        }
        
        public CategoryEnum Category
        {
            get; set;
        }
        public string ItemUrl
        {
            get; set;
        }
        
        public string ItemImage
        {
            get; set;
        }
        public string ItemPrice
        {
            get; set;
        }

        public string ItemDescription
        {
            get; set;
        }
    }
}