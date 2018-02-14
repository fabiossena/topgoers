using System;
using System.ComponentModel;

namespace TopGoers.Model
{
    public class Place : INotifyPropertyChanged
    {
        private string name;

        public int PlaceId { get; set; }
        public int StateId { get; set; }
        public int CityId { get; set; }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
