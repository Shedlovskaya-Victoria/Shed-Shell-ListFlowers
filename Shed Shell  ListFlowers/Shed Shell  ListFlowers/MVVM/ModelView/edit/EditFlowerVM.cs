using Shed_Shell__ListFlowers.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Shed_Shell__ListFlowers.MVVM.ModelView.edit
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [QueryProperty(nameof(ID), "ToID")]
    public class EditFlowerVM : INotifyPropertyChanged
    {
        private int iD;
        public int ID
        {
            get => iD;
            set
            {
                GetCategoriesList();
                if (value == 0)
                {
                    NewFlower = new Flower();
                }
                else
                {
                    NewFlower = App.dboContext.Flower.FirstOrDefault(s=>s.Id == value);
                    SelectedCateg = App.dboContext.Categories.FirstOrDefault(c => c.Id == NewFlower.CategoryFlowerId);
                    Signal(nameof(SelectedCateg));
                    Edit = true;
                }
                iD = value;
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
        public CategoryFlower SelectedCateg
        {
            get => selectedCateg;
            set
            {
                selectedCateg = value;
                Signal();
            }
        }
        private Flower newFlower;

        public List<CategoryFlower> Categories { get; private set; }
        public Command Save { get; private set; }
        public Command CloseEditForm { get; private set; }

        bool Edit = false;
        private CategoryFlower selectedCateg;

        public EditFlowerVM()
        {
           
            if (BD.Get() == null)
            {
                NewFlower = new Flower();
            }
            else
            {
                NewFlower = (Flower)BD.Get();
                SelectedCateg = App.dboContext.Categories.FirstOrDefault(c => c.Id == NewFlower.CategoryFlowerId);
                Signal(nameof(SelectedCateg));
                Edit = true;
            }
            /*костыль бд
            if (BD.Get() == null)
            {
                NewFlower = new Flower();
            }
            else
            {
                NewFlower = (Flower)BD.Get();
                SelectedCateg = App.dboContext.Categories.FirstOrDefault(c => c.Id == NewFlower.CategoryFlowerId);
                Signal(nameof(SelectedCateg));
                Edit = true;
            }
            */
            Save = new Command(async () => {

                BD.ChekNull(NewFlower);
                if (SelectedCateg == null)
                {
                    await App.Current.MainPage.DisplayAlert("Ошибка", "Выберите Категрию!", "Оk");
                    return;
                }  // BD Bd = new BD();
                if (!Edit)
                {  // Bd.AddFlower(NewFlower);
                    NewFlower.CategoryFlowerId = SelectedCateg.Id;

                    App.dboContext.Flower.Add(NewFlower);
                    App.dboContext.SaveChanges();
                }
                if (Edit)
                {  // Bd.EditFlower(NewFlower);

                    var edit = App.dboContext.Flower.FirstOrDefault(s => s.Id == NewFlower.Id);
                    edit.Name = NewFlower.Name;
                    edit.Cost = NewFlower.Cost;
                    edit.CategoryFlowerId = SelectedCateg.Id;

                    App.dboContext.SaveChanges();
                    Edit = false;
                }
                Shell.Current.GoToAsync("..");
            });
            CloseEditForm = new Command(() => {
                Shell.Current.GoToAsync("..");
            });
        }
        internal void OnAppearing()
        {
            ;
        }
        private void GetCategoriesList()
        {   // Categories = BD.GetCategories().ToList();
            Categories = App.dboContext.Categories.ToList();
            Signal(nameof(Categories));
        }
        private void CloseEditFormC(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("..");
        }

        private async void SaveC(object sender, EventArgs e)
        {
            BD.ChekNull(NewFlower);
            if (SelectedCateg == null)
            {
                await App.Current.MainPage.DisplayAlert("Ошибка", "Выберите Категрию!", "Оk");
                return;
            }  // BD Bd = new BD();
            if (!Edit)
            {  // Bd.AddFlower(NewFlower);
                NewFlower.CategoryFlowerId = SelectedCateg.Id;

                App.dboContext.Flower.Add(NewFlower);
                App.dboContext.SaveChanges();
            }
            if (Edit)
            {  // Bd.EditFlower(NewFlower);

                var edit = App.dboContext.Flower.FirstOrDefault(s => s.Id == NewFlower.Id);
                edit.Name = NewFlower.Name;
                edit.Cost = NewFlower.Cost;
                edit.CategoryFlowerId = SelectedCateg.Id;

                App.dboContext.SaveChanges();
                Edit = false;
            }
            Shell.Current.GoToAsync("..");
        }
    }
}

