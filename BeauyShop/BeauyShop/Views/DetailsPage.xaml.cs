using BeauyShop.ViewModels;
using BeauyShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Internals;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace BeauyShop.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class DetailsPage : ContentPage
    {
        string email;
        string phone;
        string mapURL;
        Items product;
        DetailsPageVM vm;


        public DetailsPage()
        {
            InitializeComponent();
            //create VM obj 
            vm = new DetailsPageVM();
            this.BindingContext = vm;

        }


    }
}