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
	public partial class FemaleFaceShape : ContentPage
	{
		public FemaleFaceShape ()
		{
			InitializeComponent ();
		}


        private async void ButtonOval_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FemaleOval());
        }

        private async void ButtonRound_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FemaleRound());
        }

        private async void ButtonSquare_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FemaleSquare());
        }

        private async void ButtonTriangle_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FemaleTriangle());
        }

    }
}