using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SMFinder
{
    public partial class MainPage : ContentPage
    {
        Label instruct;
        Image logo;
        Frame welcomeFrame, timeFrame, credFrame, entryFrame;
        Entry name, surname, phoneNum, email;
        public MainPage()
        {
            StackLayout st = new StackLayout();
            st.BackgroundColor = Color.Pink;
            Content = st;

            Frame welcomeFrame = new Frame
            {
                BorderColor = Color.PaleVioletRed,
                BackgroundColor = Color.LightPink,
                CornerRadius = 5,
                HasShadow = true,
                Margin = 3,
                Padding= 3,
                Content = new Label
                {
                    Text = "Welcome!",
                    BackgroundColor = Color.LightPink,
                    TextColor = Color.DarkRed,
                    FontSize = 24,
                    //FontFamily = "Pacifico-Regular.ttf",
                    //Style = (Style)Application.Current.Resources["Pacifico-Regular.ttf"],
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalTextAlignment = TextAlignment.Center,
                    VerticalTextAlignment = TextAlignment.Center,
                }
            };
            st.Children.Add(welcomeFrame);

            Frame timeFrame = new Frame
            {
                BorderColor = Color.PaleVioletRed,
                BackgroundColor = Color.LightPink,
                CornerRadius = 5,
                HasShadow = true,
                Margin = 3,
                Padding = 3,
                Content = new Label
                {
                    Text = "Time to Find Your Soulmate!",
                    BackgroundColor = Color.LightPink,
                    TextColor = Color.DarkRed,
                    FontSize = 24,
                    //FontFamily = "Pacifico-Regular.ttf",
                    //Style = (Style)Application.Current.Resources["Pacifico-Regular.ttf"],
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalTextAlignment = TextAlignment.Center,
                    VerticalTextAlignment = TextAlignment.Center,
                }
            };
            st.Children.Add(timeFrame);

            Frame credFrame = new Frame
            {
                BorderColor = Color.PaleVioletRed,
                BackgroundColor = Color.LightPink,
                CornerRadius = 5,
                HasShadow = true,
                Margin = 3,
                Padding = 3,
                Content = new Label
                {
                    Text = "Lets Begin With the Boring part!"+Environment.NewLine+"Please Enter Your Credentials!",
                    BackgroundColor = Color.LightPink,
                    TextColor = Color.DarkRed,
                    FontSize = 24,
                    //FontFamily = "Pacifico-Regular.ttf",
                    //Style = (Style)Application.Current.Resources["Pacifico-Regular.ttf"],
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalTextAlignment = TextAlignment.Center,
                    VerticalTextAlignment = TextAlignment.Center,
                }
            };
            st.Children.Add(credFrame);

            entryFrame = new Frame()
            {
                BorderColor = Color.PaleVioletRed,
                BackgroundColor = Color.LightPink,
                CornerRadius = 5,
                HasShadow = true,
                Margin = 3,
                Padding = 3,
                Content =
                new StackLayout()
                {
                    Children =
                    {
                        new Entry()
                        {
                            TabIndex = 0,
                            Text = "Name *",
                        },
                        new Entry()
                        {
                            TabIndex=1,
                            Text = "Second Name *",
                        },
                        new Entry()
                        {
                            TabIndex=2,
                            Text = "Phone Number *"
                        },
                        new Entry()
                        {
                            TabIndex=3,
                            Text = "Email Address *"
                        }
                    }
                }
            };
            st.Children.Add(entryFrame);

            instruct = new Label()
            {
                Text = "Press the Big Heart button belove to continue",
                TextColor = Color.DarkRed,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                FontSize = 13,
            };
            st.Children.Add(instruct);

            Image logo = new Image()
            {
                Source = "pngheartLogo.png",
            };
            st.Children.Add(logo);
            var logoBtn = new TapGestureRecognizer();
            logo.GestureRecognizers.Add(logoBtn);
            logoBtn.Tapped += LogoBtn_Tapped;
        }

        private void LogoBtn_Tapped(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
