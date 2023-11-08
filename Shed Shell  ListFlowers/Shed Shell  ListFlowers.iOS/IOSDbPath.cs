using Foundation;
using Shed_Shell__ListFlowers.iOS;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(IOSDbPath))]
namespace Shed_Shell__ListFlowers.iOS
{
    public class IOSDbPath : IDBPath
    {
        public string GetDBPath(string filename)
        {
            return Path.Combine(
                Environment.GetFolderPath(
                    Environment.SpecialFolder.MyDocuments)
                ,"..","Library", filename);
        }
    }
}