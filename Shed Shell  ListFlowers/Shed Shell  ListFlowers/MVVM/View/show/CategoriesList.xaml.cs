﻿using Shed_Shell__ListFlowers.DTO;
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
        public List<CategoryFlower> Categories
        {
            get => categories;
            set
            {
                categories = value;
                Signal();
            }
        }
        private List<CategoryFlower> categories;
        bool Edit = false;

        public CategoriesList ()
		{
			InitializeComponent ();
            BindingContext = this;
            /*
            BD bD = new BD();
            CategoryFlower categoryFlower = new CategoryFlower(); categoryFlower.Title = "Example Category";
            bD.AddCategory(categoryFlower);
            GetCategoriesList();
            */
        }
        protected override void OnAppearing()
        {
            GetCategoriesList();
            base.OnAppearing();
        }

        private void GetCategoriesList()
        {
            Categories = new List<CategoryFlower>();
            Signal(nameof(Categories));
            Categories = App.dboContext.Categories.ToList();
            //Categories = BD.GetCategories();
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
            BD.ChekNull(SelectedCategory);
            BD.Set(SelectedCategory);
            await Shell.Current.GoToAsync("EditCtg");
            GetCategoriesList();
        }

        private async void DeleteC(object sender, EventArgs e)
        {
            CheskSeleced();
            BD Bd = new BD();
            Bd.DeleteCategory(SelectedCategory);
            GetCategoriesList();
        }
        private async void AddC(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("EditCtg");
            GetCategoriesList();

        }
    }
}