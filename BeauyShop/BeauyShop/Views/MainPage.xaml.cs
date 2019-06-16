using BeauyShop.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;



namespace BeauyShop
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
         
        async void BtnLogin_Clicked(object sender, EventArgs e)
        {
           
            if (Name_Entry.Text=="somaia" && Password_Entry.Text=="1417")

            {
                DisplayAlert("Log in", "Welcome " + Name_Entry.Text + "", "ok");
                await Navigation.PushAsync(new HomePageView());

            }
            else
            {
                DisplayAlert("Log in", "Log in not correct ", "ok");
            }
        }

        
        
    }
}
