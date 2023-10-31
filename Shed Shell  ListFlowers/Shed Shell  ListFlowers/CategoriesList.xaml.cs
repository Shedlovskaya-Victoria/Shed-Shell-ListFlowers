using Shed_Shell__ListFlowers.DTO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
	public partial class CategoriesList : ContentPage, INotifyPropertyChanged
	{
        private CategoryFlower selectedCategory;
        private CategoryFlower newCategory;

        public event PropertyChangedEventHandler PropertyChanged;
        void Signal([CallerMemberName] string prop = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        public CategoryFlower SelectedCategory { 
            get => selectedCategory;
            set
            {
                selectedCategory = value;
                Signal();
            }
        }
        public CategoryFlower NewCategory { 
            get => newCategory;
            set
            {
                newCategory = value;
                Signal();
            }
        }
        public ObservableCollection<CategoryFlower> Categories
        {
            get => categories;
            set
            {
                categories = value;
                Signal();
            }
        }
        private ObservableCollection<CategoryFlower> categories;
        bool Edit = false;

        public CategoriesList ()
		{
			InitializeComponent ();
			BindingContext = this;
            BindingContext = this;
            GetCategoriesList();
            BD bD = new BD();
            CategoryFlower categoryFlower = new CategoryFlower(); categoryFlower.Title = "Example Category";
            bD.AddCategory(categoryFlower);
            GetCategoriesList();
            Routing.RegisterRoute("EditCtg", typeof(EditCategory));
        }

        private void GetCategoriesList()
        {
            BD BD = new BD();
            Categories = BD.GetCategories();
            Signal(nameof(Categories));
        }
        async void CheskSeleced()
        {
            if (SelectedCategory == null)
            {
                await DisplayAlert("Ошибка", "Выберите товар", "Понял. Исправлюсь. Сохранюсь.");
                return;
            }
        }
        private async void EditC(object sender, EventArgs e)
        {
            CheskSeleced();
            BD.Set(SelectedCategory);
            await Shell.Current.GoToAsync("EditCtg");
        }

        private async void DeleteC(object sender, EventArgs e)
        {
            CheskSeleced();
            BD Bd = new BD();
            Bd.DeleteCategory(SelectedCategory);
            GetCategoriesList();
        }

        private void CloseEditFormC(object sender, EventArgs e)
        {
            AddButtonCategory.IsVisible = true;
            NewCategory = new CategoryFlower();
        }

        private void SaveC(object sender, EventArgs e)
        {
            
            NewCategory = new CategoryFlower();
            SelectedCategory = null;
            GetCategoriesList();
        }

        private async void AddC(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("EditCtg");
        }
    }
}