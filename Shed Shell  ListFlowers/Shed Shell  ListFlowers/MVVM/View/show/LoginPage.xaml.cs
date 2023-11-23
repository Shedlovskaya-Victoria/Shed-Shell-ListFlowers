
using Shed_Shell__ListFlowers.MVVM.ModelView.show;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Shed_Shell__ListFlowers
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            //BindingContext = this;
        }
        protected override void OnAppearing()
        {
            ((LoginVM)BindingContext).OnAppearing();
        }
      
    }
}
