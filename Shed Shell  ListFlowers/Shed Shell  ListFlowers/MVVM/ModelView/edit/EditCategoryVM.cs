using Shed_Shell__ListFlowers.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace Shed_Shell__ListFlowers.MVVM.ModelView.edit
{
    public class EditCategoryVM : INotifyPropertyChanged
    {
        private CategoryFlower editFlower;
        private bool Edit;

        public event PropertyChangedEventHandler PropertyChanged;
        void Signal([CallerMemberName] string prop = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        public CategoryFlower EditFlower
        {
            get => editFlower;
            set
            {
                editFlower = value;
                Signal();
            }
        }

        public Command Save { get; set; }
        public Command CloseEditForm { get; private set; }

        public EditCategoryVM()
        {

            if (BD.Get() == null)
            {
                EditFlower = new CategoryFlower();
            }
            else
            {
                EditFlower = (CategoryFlower)BD.Get();
                Edit = true;
            }
            Save = new Command(() =>{
                BD.ChekNull(EditFlower);
                //  BD Bd = new BD();
                if (!Edit)
                {
                    //  NewFlower.Category = SelectedFlower.Category;
                    //  Bd.AddCategory(EditFlower);
                    App.dboContext.Categories.Add(EditFlower);
                    App.dboContext.SaveChanges();
                }
                if (Edit)
                {
                    //   Bd.EditCategory(EditFlower);
                    App.dboContext.Categories.FirstOrDefault(c => c.Id == EditFlower.Id).Title = EditFlower.Title;
                    App.dboContext.SaveChanges();

                    Edit = false;
                }
                GoBack();
                BD.Set(null);
            });
            CloseEditForm = new Command(() => {
                GoBack();
                Edit = false;
                BD.Set(null);
            });
        }

        internal void OnAppearing()
        {
            ;
        }

        private void SaveC(object sender, EventArgs e)
        {
            BD.ChekNull(EditFlower);
            //  BD Bd = new BD();
            if (!Edit)
            {
                //  NewFlower.Category = SelectedFlower.Category;
                //  Bd.AddCategory(EditFlower);
                App.dboContext.Categories.Add(EditFlower);
                App.dboContext.SaveChanges();
            }
            if (Edit)
            {
                //   Bd.EditCategory(EditFlower);
                App.dboContext.Categories.FirstOrDefault(c => c.Id == EditFlower.Id).Title = EditFlower.Title;
                App.dboContext.SaveChanges();

                Edit = false;
            }
            GoBack();
            BD.Set(null);
        }

        private void CloseEditFormC(object sender, EventArgs e)
        {
            GoBack();
            Edit = false;
            BD.Set(null);
        }
        void GoBack()
        {
            Shell.Current.GoToAsync("//Categ");
        }
    }
}
    

