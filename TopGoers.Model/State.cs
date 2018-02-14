using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace TopGoers.Model
{
    public class State
    {
        private string name;

        public int StateId { get; set; }

        public string Name
        {
            get { return this.name; }
            set
            {
                this.name = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
