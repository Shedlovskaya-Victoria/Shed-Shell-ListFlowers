
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Shed_Shell__ListFlowers
{
    public partial class MainShell : Shell
    {
        public MainShell()
        {
            InitializeComponent();
            BindingContext = this;
        }
       
    }
}
