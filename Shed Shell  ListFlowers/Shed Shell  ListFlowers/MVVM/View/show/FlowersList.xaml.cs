using Shed_Shell__ListFlowers.DTO;
using Shed_Shell__ListFlowers.MVVM.ModelView.show;
using Shed_Shell__ListFlowers.Tools;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Shed_Shell__ListFlowers
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FlowersList : ContentPage
    {
        public FlowersList()
		{
			InitializeComponent();
			//BindingContext = this;
        }

        protected override void OnAppearing()
        { 
            ((FlowerListVM)BindingContext).OnAppearing();
        }

    }
}