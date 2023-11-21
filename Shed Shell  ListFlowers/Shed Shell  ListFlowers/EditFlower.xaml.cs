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
        public CategoryFlower SelectedCateg { get; set; } = new CategoryFlower();
        private Flower newFlower;

        public List<CategoryFlower> Categories { get; private set; }
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
                SelectedCateg = App.dboContext.Categories.FirstOrDefault(c => c.Id == NewFlower.CategoryFlowerId);
                Edit = true;
            }
            GetCategoriesList();
        }
        private void GetCategoriesList()
        {
            Categories = App.dboContext.Categories.ToList();
          //  Categories = BD.GetCategories().ToList();
            Signal(nameof(Categories));
        }
        private void CloseEditForm(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("..");
        }

        private async void Save(object sender, EventArgs e)
        {
            BD.ChekNull(NewFlower);
            if (SelectedCateg == null)
            {
                await App.Current.MainPage.DisplayAlert("Ошибка", "Выберите Категрию!", "Оk");
                return;
            }
            // BD Bd = new BD();
            if (!Edit)
            {
                // Bd.AddFlower(NewFlower);
                NewFlower.CategoryFlowerId = SelectedCateg.Id;

                App.dboContext.Flower.Add(NewFlower);
                App.dboContext.SaveChanges();
            }
            if (Edit)
            {
                // Bd.EditFlower(NewFlower);

                App.dboContext.Flower.FirstOrDefault(s => s.Id == NewFlower.Id).Name = NewFlower.Name;;
                App.dboContext.Flower.FirstOrDefault(s => s.Id == NewFlower.Id).Cost = NewFlower.Cost;
                App.dboContext.Flower.FirstOrDefault(s => s.Id == NewFlower.Id).CategoryFlowerId = SelectedCateg.Id;

                App.dboContext.SaveChanges();
                Edit = false;
            }
            Shell.Current.GoToAsync("..");
        }
    }
}