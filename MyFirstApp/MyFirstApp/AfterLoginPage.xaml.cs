using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MyFirstApp
{	
	public partial class AfterLoginPage : ContentPage
	{	
		public AfterLoginPage ()
		{
			InitializeComponent ();
            if (Application.Current.Properties.ContainsKey("UserName"))
            {
                lbl1.Text = Application.Current.Properties["UserName"].ToString();

            }
        }
	}
}

