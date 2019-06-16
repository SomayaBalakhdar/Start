using System;
using System.Collections.Generic;
using System.Text;

namespace BeauyShop.Views
{
    class Items
    {
        private string v1;
        private string v2;
        private string v3;
        private string v4;
        public Items()
        {

        }
        public Items (string _id,string _image, string _name, string _price, string _button, string _description,string _PhoneNumber,string _email)
        {
            id = _id;
            image = _image;
            name = _name;
            price = _price;
            button = _button;
            description = _description;
            PhoneNumber = _PhoneNumber;
            email = _email;
            //GoogleMap = _GoogleMap;

        }


        // public Items(string v1, string v2, string v3, string v4)
        //{
        //    this.v1 = v1;
        //    this.v2 = v2;
        //    this.v3 = v3;
        //    this.v4 = v4;
        // }

        public string id { set; get; }
        public string image { set; get; }
        public string name { set; get; }
        public string price { set; get; }
        public string button { set; get; }
        public string description { set; get; }
        public string PhoneNumber { set; get; }
        public string email { set; get; }
        public string GoogleMap { set; get; }
    }
}
