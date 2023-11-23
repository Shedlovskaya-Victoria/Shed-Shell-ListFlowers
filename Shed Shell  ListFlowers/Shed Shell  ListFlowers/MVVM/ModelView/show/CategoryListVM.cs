using Shed_Shell__ListFlowers.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace Shed_Shell__ListFlowers.MVVM.ModelView.show
{
    public class CategoryListVM : INotifyPropertyChanged
    {
        private CategoryFlower selectedCategory;

    public event PropertyChangedEventHandler PropertyChanged;
    void Signal([CallerMemberName] string prop = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    }
    public CategoryFlower SelectedCategory
    {
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

        public Command Add { get; private set; }
        public Command EditComm { get; private set; }

        private List<CategoryFlower> categories;
    bool Edit = false;

        public Command Delete { get; private set; }

        public CategoryListVM()
    {
            /*improvise bd
            BD bD = new BD();
            CategoryFlower categoryFlower = new CategoryFlower(); categoryFlower.Title = "Example Category";
            bD.AddCategory(categoryFlower);
            GetCategoriesList();
            */
            Add = new Command(async () => {
                await Shell.Current.GoToAsync("EditCtg");
                GetCategoriesList();
            });
            EditComm = new Command(async () => {
                BD.ChekNull(SelectedCategory);
                BD.Set(SelectedCategory);
                await Shell.Current.GoToAsync("EditCtg");
                GetCategoriesList();
            });
            Delete = new Command(() => {
                CheskSeleced();
                App.dboContext.Categories.Remove(SelectedCategory);
                App.dboContext.SaveChanges();
                GetCategoriesList();
            });
        }
    internal void OnAppearing()
    {
        GetCategoriesList();
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
            await App.Current.MainPage.DisplayAlert("Ошибка", "Выберите товар", "Понял. Исправлюсь. Сохранюсь.");
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
