using BeauyShop.ViewModels;
using Plugin.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BeauyShop.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
           

        }



        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            //PhoneDialer.Open(product.PhoneNumber);
            var PhoneCall = CrossMessaging.Current.PhoneDialer;
            if (PhoneCall.CanMakePhoneCall)
            {
                PhoneCall.MakePhoneCall("0595504162","Somaia");
            }
        }
        private async void emailButton_Clicked(object sender, EventArgs e)
        {
           var emailMassenger= CrossMessaging.Current.EmailMessenger;
            if (emailMassenger.CanSendEmail)
            {
                emailMassenger.SendEmail("to soomy.15@hotmail.com","Ordering","Hello there");
            }
        }

    }
}