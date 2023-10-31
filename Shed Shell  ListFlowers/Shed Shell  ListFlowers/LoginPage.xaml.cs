
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Shed_Shell__ListFlowers
{
    public partial class LoginPage : ContentPage
    {
        public string Password { get; set; }
        public string Login { get; set; }
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = this;
        }
        async Task<bool> CheckAuthorization()
        {
            if(string.IsNullOrEmpty(Password))
            {
                await DisplayAlert("Ошибка!", "Напишите пароль!", "Ok");
                return false;
            }
            if(string.IsNullOrEmpty(Login))
            {
                await DisplayAlert("Ошибка!", "Напишите логин!", "Ok");
                return false;
            }
            if(Password == "1" && Login == "1" )
            {
                await DisplayAlert("Успех!", "Вы авторизованы!", "Ok");
                return true;
            }
            else
            {
                await DisplayAlert("Ошибка!", "Логин или пароль неверный!", "Ok");
                return false;
            }
        }
        async void CheckMethod()
        {
            if (await CheckAuthorization())
            {
                await Shell.Current.GoToAsync("//Flw");
            }
        }

        private void Authorization(object sender, EventArgs e)
        {
            CheckMethod();
        }
    }
}
