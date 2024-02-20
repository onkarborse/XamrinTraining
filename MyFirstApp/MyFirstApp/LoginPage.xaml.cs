using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MyFirstApp
{	
	public partial class LoginPage : ContentPage
	{	
		public LoginPage ()
		{
			InitializeComponent ();
		}
        private void Button_Clicked(object sender, EventArgs e)
        {
            Application.Current.Properties["UserName"] = txtuserId.Text;
            Navigation.PushAsync(new AfterLoginPage());
        }
    }
}

