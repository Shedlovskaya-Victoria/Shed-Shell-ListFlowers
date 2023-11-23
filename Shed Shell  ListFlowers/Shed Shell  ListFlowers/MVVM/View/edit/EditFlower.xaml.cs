using Shed_Shell__ListFlowers.DTO;
using Shed_Shell__ListFlowers.MVVM.ModelView.edit;
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
  //  [QueryProperty(nameof(ID), "ID")]
    public partial class EditFlower : ContentPage
    {
        public EditFlower()
        {
            InitializeComponent();
           // BindingContext = this;
        }
        protected override void OnAppearing()
        {
            ((EditFlowerVM)BindingContext).OnAppearing();
        }
    }
}