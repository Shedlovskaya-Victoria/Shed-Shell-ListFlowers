using Shed_Shell__ListFlowers.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Shed_Shell__ListFlowers
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ShellPage : Shell
	{

        public ShellPage ()
		{
			InitializeComponent();

            Routing.RegisterRoute("Edit", typeof(EditFlower));
            Routing.RegisterRoute("EditCtg", typeof(EditCategory));
            BindingContext = this;
			
		}
	}
}