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
	public partial class PlaceView : ContentPage
	{
		public PlaceView(Model.Place place = null)
		{
			InitializeComponent();
            this.BindingContext = new PlaceViewModel(place);
        }
	}
}