using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TopGoers
{
	public partial class App : Application
	{
        public static INavigation Navigation { get; private set; }

        public App ()
		{
			InitializeComponent();
            
            MainPage = new TopGoers.View.MainView();
        }

        public static Page GetMainPage()
        {
            var rootPage = new NavigationPage(new MainPage());
            Navigation = rootPage.Navigation;
            return rootPage;
        }

        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
