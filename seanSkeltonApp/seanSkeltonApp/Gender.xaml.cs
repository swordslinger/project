using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace seanSkeltonApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class login : ContentPage
	{
		public login ()
		{
			InitializeComponent ();
		}

        private async void Button_ClickedAsync(object sender, EventArgs e)
        {
            if (picker.SelectedIndex == 0)
            {
                await Navigation.PushAsync(new MalefaceShape());
            }else if (picker.SelectedIndex == 1)
            {
                await Navigation.PushAsync(new FemaleFaceShape());
            } 
            
        }




    }
}