using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace T_Shirt_Ordering_App
{
    public partial class MainPage : ContentPage
    {
        public customer newCustomer;

        private database database;

        public MainPage()
        {

            InitializeComponent();

            var path = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "databaseOrder.db");

            database = new database(path);
        }
        public void SaveBottun_Clicked(object sender, EventArgs e)
        {
            newCustomer = new customer
            {
                Name = nameEntry.Text,
                Gender = genderEntry.Text,
                TShirtSize = tShirtSizeEntry.Text,
                DateofOrder = DateTime.Now,
                TshirtColor = tShirtColorEntry.Text,
                ShippingAddress = shippingAddressEntry.Text
            };

            var page = new Page1(newCustomer);

            
            Navigation.PushAsync(page);
        }
    }
}
