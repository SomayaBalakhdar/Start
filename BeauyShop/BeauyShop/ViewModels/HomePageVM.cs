using BeauyShop.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeauyShop.Models
{
    class HomePageVM
    {
        public List<Items> itemList { set; get; }
        public HomePageVM ()
        {
            itemList = new List<Items>();
          
            fillData();
        }
       public void  fillData()
        {
           Items item1 = new Items("1","BodyCream.jpg", "BODY CREME", "$43.00", "Add to Cart","","0595504162","soomy.15@hotmail.com") ;
           Items item2 = new Items("2","bodyLotion.jpg", "BODY LOTION", "$33.00", "Add to Cart","", "0595504162", "soomy.15@hotmail.com");
           Items item3 = new Items("3","BodyWash.jpg", "BODY WASH", "$21.00", "Add to Cart","", "0595504162", "soomy.15@hotmail.com");
           Items item4 = new Items("4","BarSoap.jpg", "BAR SOAP", "$10.00", "Add to Cart","", "0595504162", "soomy.15@hotmail.com");
           Items item5 = new Items("5","perfume.jpg", "GARDENIA PARFUM", "$49.00", "Add to Cart","", "0595504162", "soomy.15@hotmail.com");
           Items item6 = new Items("6","BubbleBath.jpg", "BUBBLE BATH", "$22.00", "Add to Cart","", "0595504162", "soomy.15@hotmail.com");
           Items item7 = new Items("7","CANDLE.jpg", "VOTIVE CANDLE SET", "$18.00", "Add to Cart","", "0595504162", "soomy.15@hotmail.com");


            //list my items in order...

            itemList.Add( item1);
            itemList.Add(item2);
            itemList.Add(item3);
            itemList.Add(item4);
            itemList.Add(item5);
            itemList.Add(item6);
            itemList.Add(item7);
            
        }
        }
    }
