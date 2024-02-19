using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MyFirstApp
{
    public partial class Picker : ContentPage
    {
        public Picker()
        {
            InitializeComponent();
        }
        private void contactName_SelectedIndexChanged(object sender, EventArgs e)
        {
            var c = contactName.Items[contactName.SelectedIndex];
            DisplayAlert("Selection", c, "Ok");
        }
    }
}

