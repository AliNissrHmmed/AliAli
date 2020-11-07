using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Markup;

namespace tabledate.Models
{
   public class Table1:BaseModel
    {
        private int nU; 
        private string name;
        private string dateusing;
        public int NU
        {
            get => nU;
            set => SetProperty(ref nU, value);
        }
        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }
        public string Dateusing
        {
            get => dateusing;
            set => SetProperty(ref dateusing, value);
        }
    }
}
