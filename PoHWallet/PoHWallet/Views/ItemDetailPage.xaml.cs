using PoHWallet.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace PoHWallet.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}