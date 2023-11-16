using Shed_Shell__ListFlowers.DTO;
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
    public partial class EditFlower : ContentPage, INotifyPropertyChanged
    {
        private int iD;
        public int ID {
            get
            {
                return iD;
            }
            set
            {
                iD = value;
             /*
                if (iD == 0)
                {
                    NewFlower = new Flower();
                }
                else
                {
                   // NewFlower = BD.GetFlowerByID(iD);
                    Edit = true;
                }
             */
                
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        void Signal([CallerMemberName] string prop = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        public Flower NewFlower
        {
            get => newFlower;
            set
            {
                newFlower = value;
                Signal();
            }
        }
        private Flower newFlower;

        public ObservableCollection<CategoryFlower> Categories { get; private set; }
        bool Edit = false;

        public EditFlower()
        {
            InitializeComponent();
            BindingContext = this;
            if(BD.Get() == null)
            {
                NewFlower = new Flower();
            }
            else
            {
                NewFlower = (Flower)BD.Get();
                Edit = true;
            }
        }
        private void GetCategoriesList()
        {
            Categories = BD.GetCategories();
            Signal(nameof(Categories));
        }
        private void CloseEditForm(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("..");
        }

        private void Save(object sender, EventArgs e)
        {
            BD.ChekNull(NewFlower);
           // BD Bd = new BD();
            if (!Edit)
            {
                // Bd.AddFlower(NewFlower);
                App.dboContext.Flower.Add(NewFlower);
                App.dboContext.SaveChanges();
            }
            if (Edit)
            {
                // Bd.EditFlower(NewFlower);
                 App.dboContext.Flower.FirstOrDefault(s => s.Id == NewFlower.Id).Name = NewFlower.Name;;
                App.dboContext.Flower.FirstOrDefault(s => s.Id == NewFlower.Id).Cost = NewFlower.Cost;
                App.dboContext.Flower.FirstOrDefault(s => s.Id == NewFlower.Id).CategoryFlowerId = NewFlower.CategoryFlowerId;

                App.dboContext.SaveChanges();
                Edit = false;
            }
            Shell.Current.GoToAsync("..");
        }
    }
}