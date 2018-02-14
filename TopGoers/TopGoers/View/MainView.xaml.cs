using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopGoers.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TopGoers.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainView : MasterDetailPage
    {
        public MainView()
        {
            InitializeComponent();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
            //this.Master = new MainViewMaster();
            //this.Detail = new MainViewDetail();
            Detail = new NavigationPage(new PlacesView());
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as IMainViewMenuItem;
            if (item == null)
                return;

            if (item.Id == 0)
            {
                Detail = new NavigationPage(new PlacesView());
            }
            else
            {
                var page = (Page)Activator.CreateInstance(item.TargetType);
                page.Title = item.Title;
                Detail = new NavigationPage(page);
            }

            IsPresented = false;

            MasterPage.ListView.SelectedItem = null;
        }
    }
}