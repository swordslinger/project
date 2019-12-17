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
	public partial class MalefaceShape : ContentPage
	{
		public MalefaceShape ()
		{
			InitializeComponent ();
		}


        private async void ButtonDiamond_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MaleDiamond());
        }

        private async void ButtonOval_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MaleOval());
        }

        private async void ButtonRound_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MaleRound());
        }

        private async void ButtonSquare_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MaleSquare());
        }
    }
}