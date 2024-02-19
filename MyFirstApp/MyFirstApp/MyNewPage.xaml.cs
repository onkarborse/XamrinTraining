using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace MyFirstApp
{
    public partial class MyNewPage : ContentPage
    {
        //public MyNewPage ()
        //{
        //	InitializeComponent ();
        //}
        //      private void Button_Clicked_1(object sender, EventArgs e)
        //      {
        //          if (sender == "admin")
        //          {
        //              DisplayAlert("Login success", "Okay", "Cancel");
        //          } else
        //          {
        //              DisplayAlert("Login failed", "Okay", "Cancel");
        //          }
        //      }

        //      private void Button_Clicked_2(object sender, EventArgs e)
        //      {
        //          label1.Text = fName.Text + " " + lName.Text;
        //      }
        //      void Button_Clicked(System.Object sender, System.EventArgs e)
        //      {
        //      }

        public MyNewPage()
        {
            InitializeComponent();

            //label1.SetValue = 0;
            //Content = new Label
            //{
            //    Text = "Hello now render via code behind...",
            //    HorizontalOptions = LayoutOptions.Center,
            //    VerticalOptions = LayoutOptions.Center
            //};
        }

        //void fName_TextChanged(System.Object sender, Xamarin.Forms.TextChangedEventArgs e)
        //{
        //    label1.Text = e.NewTextValue;
        //}
        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {

            label1.Text = string.Format("Value is {0:F2}", e.NewValue);
            label2.FontSize = e.NewValue;
        }
        //void Slider_ValueChanged(System.Object sender, Xamarin.Forms.ValueChangedEventArgs e)
        //{
        //}

        //void Slider_ValueChanged_1(System.Object sender, Xamarin.Forms.ValueChangedEventArgs e)
        //{
        //}
    }

}

