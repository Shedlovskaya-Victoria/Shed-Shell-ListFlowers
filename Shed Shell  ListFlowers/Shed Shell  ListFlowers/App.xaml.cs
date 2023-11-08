using Shed_Shell__ListFlowers.DTO;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Shed_Shell__ListFlowers
{
    public partial class App : Application
    {
        private const string FILE_NAME = "FlowerList.db";
        private static DboContext dboContext1;

        public static DboContext dboContext { //аксесер
            get
            {
                string path = DependencyService.Get<IDBPath>().GetDBPath(FILE_NAME);
                dboContext1 = new DboContext(path);
                dboContext1.Database.EnsureCreated();
;              return  dboContext1;//выделить амяь для подключения, а если памят ь 
                //не надо выделять мф и так вададим готовое подключение
                //Combine - это обьедияет несмколько значений в один большой путь
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new ShellPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
