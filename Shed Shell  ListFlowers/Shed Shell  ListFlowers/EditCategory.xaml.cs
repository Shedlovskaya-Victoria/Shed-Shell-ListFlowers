﻿using Shed_Shell__ListFlowers.DTO;
using System;
using System.Collections.Generic;
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
    public partial class EditCategory : ContentPage, INotifyPropertyChanged
    {
        private CategoryFlower editFlower;

        public event PropertyChangedEventHandler PropertyChanged;
        void Signal([CallerMemberName] string prop = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        public CategoryFlower EditFlower { 
            get => editFlower;
            set
            {
                editFlower = value;
                Signal();
            }
        }
        public EditCategory()
        {
            InitializeComponent();
            BindingContext = this;
            EditFlower = (CategoryFlower)BD.Get();
        }

        private void SaveC(object sender, EventArgs e)
        {
            CheskSeleced();
            BD Bd = new BD();
            AddButtonCategory.IsVisible = true;
            if (!Edit)
            {
                //  NewFlower.Category = SelectedFlower.Category;
                Bd.AddCategory(EditFlower);
            }
            if (Edit)
            {
                Bd.EditCategory(EditFlower);
                Edit = false;
            }
            GoBack();
        }

        private void CloseEditFormC(object sender, EventArgs e)
        {
           GoBack();
        }
        void GoBack()
        {
            Shell.Current.GoToAsync("//Categ");
        }
    }
}