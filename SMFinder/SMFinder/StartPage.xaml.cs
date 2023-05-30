using SMFinder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SMFinder
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartPage : ContentPage
    {
        Image img;
        public StartPage()
        {
            StackLayout st = new StackLayout();
            Content= st;

            img = new Image
            {
                Source = "pngheartLogo.png",
                
            };
            st.Children.Add(img);
            var logoBtn = new TapGestureRecognizer();
            img.GestureRecognizers.Add(logoBtn);
            logoBtn.Tapped += LogoBtn_Tapped; ;

        }

        private async void LogoBtn_Tapped(object sender, EventArgs e)
        {
            User user = new User();
            MainPage mainPage = new MainPage();
            mainPage.BindingContext = user;
            await Navigation.PushAsync(mainPage);
        }
    }
}