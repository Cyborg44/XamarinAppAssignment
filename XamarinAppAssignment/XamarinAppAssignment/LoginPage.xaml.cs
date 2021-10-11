using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinAppAssignment.Models;
using System.Reflection;

namespace XamarinAppAssignment
{
    public partial class LoginPage : ContentPage

    {
        

        public LoginPage()
        {
            

            InitializeComponent();
        }

        private async void Login_Button_Clicked(object sender, EventArgs e)
        {
            if(username.Text == "cool" && password.Text == "cool"){

                Profile profile = new Profile
                {
                    FirstName = "Sarthak",
                    LastName = "Chauhan",
                    Email = "chauhan.sarthak@tcs.com",
                    DOB = "00/00/0000",
                    Gender = "Male",
                    

                };

                await Navigation.PushAsync(new ProfilePage(profile));
            }
            else
            {
                await DisplayAlert("Alert", "Username or Password is incorrect!!", "OK");
            }
        }

        private async void Signup_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignupPage());
        }

       


    }
}
