using Acr.UserDialogs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using tabledate.Models;
using tabledate.Services;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace tabledate.ViewModels
{
    public class HomeViewModel:BaseViewModel
    {
        private List<Table1> dataList;
        public List<Table1> DataList
        {
            get => dataList;
            set => SetProperty(ref dataList, value);
        }
        public ICommand GoToDateusingCommand { get; }

        public HomeViewModel(INavigation navigation, IUserDialogs dialogs) : base(navigation, dialogs)
        {
            Task.Run(InitDB);
            Task.Run(async () => await GetScripts());
            GoToDateusingCommand = new Command<Table1>(GoToDateusing);
        }

        async Task InitDB()
        {
            MainThread.BeginInvokeOnMainThread(() => IsBusy = true);
            WebServices.InitDb();
            MainThread.BeginInvokeOnMainThread(() => IsBusy = false);
        }
        private async Task<bool> GetScripts()
        {
            IsBusy = true;
            DataList = await WebServices.GetAllTable1();
            IsBusy = false;
            return true;
        }
        private async void GoToDateusing(Table1 data)
        {
            await Navigation.PushAsync(new Views.DateusingView(data));
        }
    }
}
