using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SMFinder.Models;

namespace SMFinder
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        int FriendId;
        private async void SaveData(object sender, EventArgs e)
        {
            var friend = (User)BindingContext;
            if (!String.IsNullOrEmpty(friend.Name))
            {
                App.Database.SaveItem(friend);
                FriendId= friend.Id;
            }

            await DisplayAlert("Buba", FriendId.ToString(), "Ok");
        }
    }
}
