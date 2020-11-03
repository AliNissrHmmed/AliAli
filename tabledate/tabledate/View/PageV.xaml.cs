using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabledate.srevicce;
using tabledate.ViewModal;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace tabledate.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageV : ContentPage
    {
        public PageV()
        {
             Task.Run(InitDB);
            InitializeComponent();
            BindingContext = new pageVM();
        }
        async Task InitDB()
        {
            MainThread.BeginInvokeOnMainThread(() => IsBusy = true);
            DateBase.InitDb();
            MainThread.BeginInvokeOnMainThread(() => IsBusy = false);
        }
    }
}