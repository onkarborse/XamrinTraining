using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MyFirstApp
{	
	public partial class ListView : ContentPage
	{	
		public ListView ()
		{
			InitializeComponent ();
            var names = new List<string>
            {
                "abc",
                "xyz",
                "Rana",
                "Ram"

            };
            list1.ItemsSource = names;
        }
	}
}

