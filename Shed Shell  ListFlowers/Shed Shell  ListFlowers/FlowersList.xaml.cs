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
        private ObservableCollection<CategoryFlower> categories;
        private List<Flower> flowers;
        private List<CategoryFlower> categories1;

        public CustomCommand<Flower> Remove { get; set; }
        public CustomCommand<Flower> Edit { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public List<Flower> Flowers { 
            get => flowers;
            set
            {
                flowers = value;
                Signal();
            }
        }
        public List<CategoryFlower> Categories
        {
            get => categories1;
            set {
                categories1 = value;
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


        void Signal([CallerMemberName] string prop = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        public FlowersList()
		{
			InitializeComponent();
			BindingContext = this;
            /*   add and show categ list
             *   GetCategoriesList();
                 Categories = new ObservableCollection<CategoryFlower> {
                 new CategoryFlower { Title = "1 ctg" },
                 new CategoryFlower { Title = "2 ctg" } };
                 CategoryFlower categoryFlower = new CategoryFlower(); categoryFlower.Title = "ExCtg";
            */
            /* add and show flow list
             * Flower newF = new Flower(); newF.Name = "FirstExFlwr"; newF.Cost = 32; newF.Category = categoryFlower;
               GetDBFlowerList();
               GetFlowerList();
               Bd.AddFlower(newF);
               GetFlowerList();
               GetCategoriesList();
            */
            Remove = new CustomCommand<Flower>( (item) =>
            {
                BD.ChekNull(SelectedFlower);
                App.dboContext.Flower.Remove(item);
                App.dboContext.SaveChanges();
                GetDBFlowerList();
            });
            Edit = new CustomCommand<Flower>( async (item) =>
            {
                BD.ChekNull(item);
                BD.Set(item);
                await Shell.Current.GoToAsync($"Edit");
                GetDBFlowerList();
            });
        }

        protected override void OnAppearing()
        {

            GetDBCategoryList();
            GetDBFlowerList();
            base.OnAppearing();
        }

        private void GetDBFlowerList()
        {  var Flower = new Flower {  Name = "ExFlowName", CategoryFlowerId = 1 };
           App.dboContext.Flower.Add(Flower);  App.dboContext.SaveChanges();

            //CategTitle.Text = App.dboContext.Categories.Select(c => c.Id == 1).ToString();
            //Signal(nameof(CategTitle));
            Flowers = new List<Flower>();
            Signal(nameof(Flowers));
            Flowers = App.dboContext.Flower.ToList();
            Signal(nameof(Flowers));
        }
        private void GetDBCategoryList()
        {
            Categories = App.dboContext.Categories.ToList();
            Signal(nameof(Categories));

            var categ = new CategoryFlower { Title = "ExCategTitle" };
            App.dboContext.Categories.Add(categ);  
            App.dboContext.SaveChanges();

            Categories = new List<CategoryFlower>();
            Signal(nameof(Categories));
            Categories = App.dboContext.Categories.ToList();
            Signal(nameof(Categories));
        }

        private void GetFlowerList()
        {
            Flowers = BD.GetInstance().ToList();
            Signal(nameof(Flowers));
        }

        private void GetCategoriesList()
        {
            Categories = BD.GetCategories().ToList();
            Signal(nameof(Categories));
        }

        private async void AddFlower(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"Edit");
            //    GetFlowerList();
            
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