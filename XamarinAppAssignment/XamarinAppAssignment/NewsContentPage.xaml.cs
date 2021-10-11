using XamarinAppAssignment.Models;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinAppAssignment
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewsContentPage : ContentPage
    {
        public NewsContentPage(News news)
        {
            if (news == null)
            {
                throw new ArgumentNullException();
            }

            BindingContext = news;
            InitializeComponent();
        }
    }
}