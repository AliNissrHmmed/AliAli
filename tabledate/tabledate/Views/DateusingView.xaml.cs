using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabledate.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace tabledate.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DateusingView : ContentPage
    {
        public DateusingView(Table1 data)
        {
            InitializeComponent();
            BindingContext = new ViewModels.DateusingViewModel(Navigation, Acr.UserDialogs.UserDialogs.Instance,data);
        }
    }
}