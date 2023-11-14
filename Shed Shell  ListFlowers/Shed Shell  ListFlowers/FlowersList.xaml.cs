using Shed_Shell__ListFlowers.DTO;
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
	public partial class FlowersList : ContentPage, INotifyPropertyChanged
    {
        private Flower selectedFlower;

        public event PropertyChangedEventHandler PropertyChanged;
        public List<Flower> Flowers { 
            get => flowers;
            set
            {
                flowers = value;
                Signal();
            }
        }
        public Flower SelectedFlower { 
            get => selectedFlower;
            set
            {
                selectedFlower = value;
                Signal();
            }
        }
        
        bool Edit = false;
        private ObservableCollection<CategoryFlower> categories;
        private List<Flower> flowers;

        public ObservableCollection<CategoryFlower> Categories { 
            get => categories;
            set
            {
                categories = value;
                Signal();
            }
        }

        public CustomCommand<Flower> Remove { get; set; }

        void Signal([CallerMemberName] string prop = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        public FlowersList()
		{
			InitializeComponent();
			BindingContext = this;

            Flowers = App.dboContext.Flower.ToList();

          //  GetCategoriesList();
           /* Categories = new ObservableCollection<CategoryFlower> {
                new CategoryFlower { Title = "1 ctg" },
                new CategoryFlower { Title = "2 ctg" } };
            CategoryFlower categoryFlower = new CategoryFlower(); categoryFlower.Title = "ExCtg";
           */
           // Flower newF = new Flower(); newF.Name = "FirstExFlwr"; newF.Cost = 32; newF.Category = categoryFlower;
         //   GetDBFlowerList();
           // GetFlowerList();
           //  Bd.AddFlower(newF);
           //   GetFlowerList();
           // GetCategoriesList();

            Remove = new CustomCommand<Flower>( (item) =>
            {
                BD.ChekNull(SelectedFlower);
                App.dboContext.Flower.Remove(item);
                App.dboContext.SaveChanges();
                GetDBFlowerList();
            });
        }
        private void GetDBFlowerList()
        {//  var Flower = new Flower {  Name = "Name" };
          //  App.dboContext.Flower.Add(Flower);  App.dboContext.SaveChanges();

            Flowers = App.dboContext.Flower.ToList();
            Signal(nameof(Flowers));
        }

        private void GetFlowerList()
        {
            Flowers = BD.GetInstance().ToList();
            Signal(nameof(Flowers));
        }

        private void GetCategoriesList()
        {
            Categories = BD.GetCategories();
            Signal(nameof(Categories));
        }

        private async void AddFlower(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"Edit");
            //    GetFlowerList();
            GetDBFlowerList();
        }

        private async void DeleteFlower(object sender, EventArgs e)
        {
            BD.ChekNull(SelectedFlower);
            // BD Bd = new BD();
            //  Bd.DeleteFlower(SelectedFlower);
            App.dboContext.Flower.Remove(SelectedFlower);
            GetDBFlowerList();

        }

        private async void EditFlower(object sender, EventArgs e)
        {
            if (SelectedFlower.Id == 0)
            {
                await DisplayAlert("Ошибка", "Выберите товар", "Понял. Исправлюсь. Сохранюсь.");
                return;
            }
            BD.Set(SelectedFlower);
            await Shell.Current.GoToAsync($"Edit");
            //  GetFlowerList();
            GetDBFlowerList();

        }
    }
}