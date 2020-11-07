using Acr.UserDialogs;
using System;
using System.Collections.Generic;
using System.Text;
using tabledate.Models;
using Xamarin.Forms;

namespace tabledate.ViewModels
{
    public class DateusingViewModel:BaseViewModel
    {
        private Table1 data;
        public Table1 Data
        {
            get => data;
            set => SetProperty(ref data, value);
        }
        public DateusingViewModel(INavigation navigation, IUserDialogs dialogs,Table1 data) : base(navigation, dialogs)
        {
            Data = data;
        }
    }
}
