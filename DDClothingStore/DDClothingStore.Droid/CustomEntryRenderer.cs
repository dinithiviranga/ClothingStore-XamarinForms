using Android.Content;
using DDClothingStore;
using DDClothingStore.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
[assembly: ExportRenderer(typeof(ClothingStoreEntry), typeof(ClothingStoreEntryRenderer))]
namespace DDClothingStore.Droid
{
    public class ClothingStoreEntryRenderer : EntryRenderer
    {
        public ClothingStoreEntryRenderer(Context context) : base(context)
        {
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            Control?.SetBackgroundColor(Android.Graphics.Color.Transparent);
        }
    }
}