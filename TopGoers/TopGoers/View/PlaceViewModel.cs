using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using TopGoers.ViewModel;
using TopGoers.Model;

namespace TopGoers.View
{
    public class PlaceViewModel : BaseViewModel, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Place Place { get; set; }

        public PlaceViewModel(Place place)
        {
            this.Place = place;
        }
    }
}
