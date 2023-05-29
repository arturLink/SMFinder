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
    public partial class CharPage : ContentPage
    {
        Picker char1, char2, char3;
        List<string> traitsList = new List<string> { "Funny", "Generous", "Empathetic", "Serious", "Confident", "Talkative", "Boring", "Caring" };
        public CharPage()
        {
            WelcomePopUp();
            StackLayout st = new StackLayout();
            Content = st;
            st.BackgroundColor = Color.Pink;
            //Char1
            char1 = new Picker()
            {
                Title = "Select your first trait",
                BackgroundColor = Color.LightPink,
            };
            foreach (string trait in traitsList) 
            {
                char1.Items.Add(trait);
            }
            st.Children.Add(char1);

            //Char2
            char2 = new Picker()
            {
                Title = "Select your first trait",
            };
            foreach (string trait in traitsList)
            {
                char2.Items.Add(trait);
            }
            st.Children.Add(char2);

            //Char3
            char3 = new Picker()
            {
                Title = "Select your first trait",
            };
            foreach (string trait in traitsList)
            {
                char3.Items.Add(trait);
            }
            st.Children.Add(char3);
        }

        public async void WelcomePopUp()
        {
            await DisplayAlert("Welcome", "Now for the final and more interesting step!", "Ok");
        }
    }
}