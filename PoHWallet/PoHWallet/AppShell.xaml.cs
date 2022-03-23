using PoHWallet.ViewModels;
using PoHWallet.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace PoHWallet
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(VideoRecorder), typeof(VideoRecorder));
        }

    }
}
