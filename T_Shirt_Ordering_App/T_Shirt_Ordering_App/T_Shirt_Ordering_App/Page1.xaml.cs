using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace T_Shirt_Ordering_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();

        }
        
        public Page1(customer newCustomer)
        {
            NewCustomer = newCustomer;
        }

        public customer NewCustomer { get; }
    }
}