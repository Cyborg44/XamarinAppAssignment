using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinAppAssignment.Models;
using Plugin.Media;

namespace XamarinAppAssignment
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignupPage : ContentPage

    {
        string base64;


        public SignupPage()
        {
            

            InitializeComponent();
            
        }

        async void ImageButton_Clicked(object sender, EventArgs e)
        {
                
                var result = await CrossMedia.Current.PickPhotoAsync(new Plugin.Media.Abstractions.PickMediaOptions
                {
                    CompressionQuality = 30,
                    CustomPhotoSize = 50,
                    PhotoSize = Plugin.Media.Abstractions.PhotoSize.MaxWidthHeight,
                    MaxWidthHeight = 2000
                    
                    
                }).ConfigureAwait(true);
                
                var stream = result.GetStream();
                var bytes = new byte[stream.Length];
                await stream.ReadAsync(bytes, 0, (int)stream.Length);
                base64 = System.Convert.ToBase64String(bytes);
                photoName.Text = "myphoto.jpg";
                

           

        }

        private async void Signup_Button_Clicked(object sender, EventArgs e)
        {
            Profile profile = new Profile
            {
                FirstName = fname.Text,
                LastName = lName.Text,
                Email = email.Text,
                DOB = dob.Date.ToString(),
                Gender = gender.Items[gender.SelectedIndex],
                Image = base64
                
            };
                  

            await Navigation.PushAsync(new ProfilePage(profile));
        }

        
    }
}