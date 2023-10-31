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
	public partial class FlowersList : ContentPage, INotifyPropertyChanged
    {
        private Flower selectedFlower;

        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<Flower> Flowers { 
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
        private ObservableCollection<Flower> flowers;

        public ObservableCollection<CategoryFlower> Categories { 
            get => categories;
            set
            {
                categories = value;
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
            BD Bd = new BD();
            GetCategoriesList();
            Categories = new ObservableCollection<CategoryFlower> {
                new CategoryFlower { Title = "1 ctg" },
                new CategoryFlower { Title = "2 ctg" } };
            CategoryFlower categoryFlower = new CategoryFlower(); categoryFlower.Title = "ExCtg";
            Flower newF = new Flower(); newF.Name = "FirstExFlwr"; newF.Cost = 32; newF.Category = categoryFlower;
            GetFlowerList();
            Bd.AddFlower(newF);
            GetFlowerList();
            GetCategoriesList();
            Routing.RegisterRoute("Edit", typeof(EditFlower));
        }

        private void GetFlowerList()
        {
            Flowers = BD.GetInstance();
            Signal(nameof(Flowers));
        }

        private void GetCategoriesList()
        {
            Categories = BD.GetCategories();
            Signal(nameof(Categories));
        }

        private async void AddFlower(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"Edit?ID={null}");
            GetFlowerList();
        }

        private async void DeleteFlower(object sender, EventArgs e)
        {
            if(SelectedFlower == null)
            {
                await DisplayAlert("Ошибка", "Выберите товар", "Понял. Исправлюсь. Сохранюсь.");
                return;
            }
            BD Bd = new BD();
            Bd.DeleteFlower(SelectedFlower);
            GetFlowerList();
        }

        private async void EditFlower(object sender, EventArgs e)
        {
            if (SelectedFlower.Id == 0)
            {
                await DisplayAlert("Ошибка", "Выберите товар", "Понял. Исправлюсь. Сохранюсь.");
                return;
            }
            await Shell.Current.GoToAsync($"Edit?ID={SelectedFlower.Id}");
            GetFlowerList();
        }
    }
}