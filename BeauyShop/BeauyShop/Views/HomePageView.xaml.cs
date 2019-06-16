using BeauyShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BeauyShop.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePageView : ContentPage
    {
        HomePageVM homePageVM;
        public HomePageView()
        {
            InitializeComponent();
            homePageVM = new HomePageVM();
            this.BindingContext = homePageVM;
            
        }
        private async void OnItemSelected(Object sender, ItemTappedEventArgs e)
        {
            var mydetail = e.Item as Items;
           switch (mydetail.id)
            {
                case "1":
                    await Navigation.PushAsync(new Page1() );
                    break;
                case "2":
                    await Navigation.PushAsync(new Page2());
                    break;
                case "3":
                    await Navigation.PushAsync(new Page3());
                    break;
                case "4":
                    await Navigation.PushAsync(new Page4());
                    break;
                case "5":
                    await Navigation.PushAsync(new Page5());
                    break;
                case "6":
                    await Navigation.PushAsync(new Page6());
                    break;
                case "7":
                    await Navigation.PushAsync(new Page7());
                    break;

            }
        }
    }
}