using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabledate.Modal;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace tabledate.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2VV : ContentPage
    {
        public Page2VV(Table1 selected)
        {
            InitializeComponent();
        }
    }
}