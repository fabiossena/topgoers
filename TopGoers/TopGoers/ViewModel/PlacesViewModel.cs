using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TopGoers.Model;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;
using TopGoers.View;
using Xamarin.Forms.Navigation;
using System.Threading.Tasks;

namespace TopGoers.ViewModel
{
    public class PlacesViewModel : BaseViewModel, INotifyPropertyChanged
    {
        public ICommand SearchCommand { get; set; }
        public ICommand SearchCancelCommand { get; set; }
        public ICommand StateChangedCommand { get; set; }
        public ICommand ListPlacesItemTappedCommand { get; set; }
        public ICommand FilterCommand { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private INavigationService NavigationService { get; set; }

        private string search;
        private ObservableCollection<City> cities;
        private ObservableCollection<State> states;
        private ObservableCollection<Place> places;
        private State selectedState;
        private City selectedCity;
        private bool isVisibleFilter;


        public PlacesViewModel()
        {
            this.NavigationService = new NavigationService();
            this.LoadStates();

            this.SearchCommand = new Xamarin.Forms.Command(ExecuteSearch);
            this.SearchCancelCommand = new Xamarin.Forms.Command(SearchCancel);
            this.StateChangedCommand = new Xamarin.Forms.Command(StateChanged);
            this.ListPlacesItemTappedCommand = new Xamarin.Forms.Command(ListPlacesItemTapped);
            this.FilterCommand = new Xamarin.Forms.Command(Filter);

            this.ExecuteSearch(null);
        }

        public ObservableCollection<Place> Places
        {
            get => this.places;
            set
            {
                this.places = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Places)));
            }
        }

        public ObservableCollection<State> States
        {
            get => this.states;
            set
            {
                this.states = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(States)));
            }
        }

        public ObservableCollection<City> Cities
        {
            get => this.cities;
            set
            {
                this.cities = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Cities)));
            }
        }

        public bool IsVisibleFilter
        {
            get => this.isVisibleFilter;
            set
            {
                this.isVisibleFilter = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsVisibleFilter)));
            }
        }

        public State SelectedState
        {
            get
            {
                return this.selectedState;
            }

            set
            {
                this.selectedState = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedState)));
            }
        }

        public City SelectedCity
        {
            get => this.selectedCity;
            set
            {
                this.selectedCity = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedCity)));

            }
        }

        public string Search
        {
            get { return search; }
            set
            {
                search = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Search)));
            }
        }

        private async void LoadStates()
        {
            this.States = new ObservableCollection<State>(await this.StateService.GetAsync());
        }

        private async void ExecuteSearch(object obj)
        {
            this.Places = new ObservableCollection<Place>(await this.PlaceService.GetAsync(this.SelectedState?.StateId, this.SelectedCity?.CityId, this.Search));
            this.SearchCancel(null);
        }

        private void SearchCancel(object obj)
        {
            IsVisibleFilter = false;
        }

        public async void StateChanged(object obj)
        {
            this.Cities = new ObservableCollection<City>(await this.CityService.GetAsync(this.SelectedState?.StateId));
            this.SelectedCity = null;
        }

        private async void ListPlacesItemTapped(object obj)
        {
            var itemTappedEventArgs = obj as ItemTappedEventArgs;
            if (itemTappedEventArgs == null)
            {
                return;
            }

            await ((MainView)App.Current.MainPage).Detail.Navigation.PushAsync(new PlaceView(itemTappedEventArgs.Item as Place));
            //await this.NavigationService.PushAsync(new PlaceView(itemTappedEventArgs.Item as Place));
        }

        private async void Filter(object obj)
        {
            IsVisibleFilter = true;
        }
    }
}
