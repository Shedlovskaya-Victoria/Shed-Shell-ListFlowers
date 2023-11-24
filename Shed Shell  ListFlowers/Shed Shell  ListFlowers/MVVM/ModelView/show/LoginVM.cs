using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Shed_Shell__ListFlowers.MVVM.ModelView.show
{
    public class LoginVM
    {
        public LoginVM()
        {
            AuthorizationComm = new Command(() => {
                CheckMethod();
            });
        }

        public string Password { get; set; }
        public string Login { get; set; }
        public Command AuthorizationComm { get; private set; }

        async Task<bool> CheckAuthorization()
        {
            if (string.IsNullOrEmpty(Password))
            {
                await App.Current.MainPage.DisplayAlert("Ошибка!", "Напишите пароль!", "Ok");
                return false;
            }
            if (string.IsNullOrEmpty(Login))
            {
                await App.Current.MainPage.DisplayAlert("Ошибка!", "Напишите логин!", "Ok");
                return false;
            }
            if (Password == "1" && Login == "1")
            {
                //  await DisplayAlert("Успех!", "Вы авторизованы!", "Ok");
                return true;
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Ошибка!", "Логин или пароль неверный!", "Ok");
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
