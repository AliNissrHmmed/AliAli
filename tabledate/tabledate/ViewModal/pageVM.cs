using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using tabledate.Modal;
using tabledate.srevicce;
using tabledate.View;

namespace tabledate.ViewModal
{
    class pageVM :dispaly
    { 
        public pageVM()
        {
            Tabee = DateBase.GetAll().Result;
        }

        private List<Table1> tabee;

        public List<Table1> Tabee
        {
            get => tabee;
            set { SetValue(ref tabee, value); }
        }
        private string name;

        public string Name
        {
            get => name;
            set { SetValue(ref name, value); }
        }



        //private Table1 selected;
        //public Table1 Eelected
        //{
        //    get => selected;
        //    set 
        //    { 
        //        SetValue(ref selected, value);
        //        App.Current.MainPage.Navigation.PushAsync(new Page2VV(selected));
        //             SetValue(ref selected, null);
        //    }
        //}

    }
}
