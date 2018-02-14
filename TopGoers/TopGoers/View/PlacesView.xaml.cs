using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TopGoers.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PlacesView : ContentPage
	{
		public PlacesView ()
		{            
			InitializeComponent ();

            this.ListPlaces.ItemTapped +=  (async (s, e) =>
            {
                var item = e.Item as Model.Place;


                //await App.Current.MainPage.Navigation.PushAsync(new PlaceView(item));

                //var mainPage = new MainPage();//this could be content page
                //var rootPage = new NavigationPage(mainPage);
                //await rootPage.PushAsync(new PlaceView(item));
                //App.Current.MainPage.Navigation = rootPage.Navigation;
                //await  this.Navigation.PushModalAsync(new PlaceView(item));
            });

        }
    }
}