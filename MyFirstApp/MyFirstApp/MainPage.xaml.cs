using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Xamarin.Forms;

namespace MyFirstApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //void Button_Clicked(System.Object sender, System.EventArgs e)
        //{
        //}

        //void Button_Clicked_1(System.Object sender, System.EventArgs e)
        //{
        //    DisplayAlert("display","now","ok");
        //}
        //private void Button_Clicked_1(object sender, EventArgs e)
        //{
        //    label1.Text = "Hello Xamarin";
        //}
        private void Button_Clicked_1(object sender, EventArgs e)
        {
            label1.Text = fName.Text + " " + lName.Text;
        }
    }
}

