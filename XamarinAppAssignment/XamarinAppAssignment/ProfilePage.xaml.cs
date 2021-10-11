using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Media;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinAppAssignment.Models;

namespace XamarinAppAssignment
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage(Profile profile)

        {
           
            string str = profile.Image;
            byte[] Base64Stream = Convert.FromBase64String(str);

            



            InitializeComponent();

            var layout = new StackLayout { Padding = new Thickness(5, 10) };

            Label Name = new Label
            {
                Text = profile.FirstName + profile.LastName,
                FontSize = 20

            };

            Label DOB = new Label
            {
                Text = profile.DOB,
                FontSize = 20

            };

            Label Gender = new Label
            {
                Text = profile.Gender,
                FontSize = 20

            };

            Label Email = new Label
            {
                Text = profile.Email,
                FontSize = 20

            };




            Image pImage = new Image
            {

                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                HeightRequest = 100,
                WidthRequest = 100,
                BackgroundColor = Color.Black
            };
            pImage.Source = ImageSource.FromStream(() => new MemoryStream(Base64Stream));

            layout.Children.Add(Name);
            layout.Children.Add(Email);
            layout.Children.Add(Gender);
            layout.Children.Add(DOB);
            layout.Children.Add(pImage);

            this.Content = layout;

        }
    }
}