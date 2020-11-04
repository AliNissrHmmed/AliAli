using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using tabledate.Models;
using Xamarin.Essentials;
using static System.Net.WebRequestMethods;

namespace tabledate.Services
{
   public class WebServices
    {
        private static SQLiteAsyncConnection conn;
        public static SQLiteAsyncConnection Connection
        {
            get
            {
                if (conn == null)
                    conn = new SQLiteAsyncConnection(tabledate_DATABASE_PATH);
                return conn;
            }
        }
        public static void InitDb()
        {
            var embeddedResourceDb = Assembly.GetExecutingAssembly().
                GetManifestResourceNames().First(s => s.Contains("TableDatebase.db"));
            var embeddedResourceDbStream = Assembly.GetExecutingAssembly().
                GetManifestResourceStream(embeddedResourceDb);

            // Load data from bundle to phone cache on first launch
            if (!System.IO.File.Exists(tabledate_DATABASE_PATH))
            {
                using var br = new BinaryReader(embeddedResourceDbStream);
                using var bw = new BinaryWriter(new FileStream(tabledate_DATABASE_PATH, FileMode.Create));
                var buffer = new byte[2048];
                int len;
                while ((len = br.Read(buffer, 0, buffer.Length)) > 0)
                {
                    bw.Write(buffer, 0, len);
                }
            }
            else
            {
                if (VersionTracking.IsFirstLaunchForCurrentVersion)
                {
                    System.IO.File.Delete(tabledate_DATABASE_PATH);
                    InitDb();
                }
            }
        }
        private static readonly string tabledate_DATABASE_PATH = Path.Combine
     (Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "TableDatebase.db");

        public static Task<List<Table1>> GetAllTable1()
        {
            return Connection.Table<Table1>().ToListAsync();
        }
       
    }
}
