using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Shed_Shell__ListFlowers.Droid;
using System;
using System.Collections.Generic;
using System.IO;
using Xamarin.Forms;
using Xamarin.Android;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

[assembly: Xamarin.Forms.Dependency(typeof(AndroidDbPath))]
namespace Shed_Shell__ListFlowers.Droid
{
    public class AndroidDbPath : IDBPath
    {
        public string GetDBPath(string filename)
        {
            return Path.Combine(
                Environment.GetFolderPath(
                Environment.SpecialFolder.Personal) ,
                filename);
        }
    }
}