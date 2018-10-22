using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsExample.Models {

    public class Car : INotifyPropertyChanged{
        private int _yearOfModel;
        private bool _isDescriptionVisible;

        public int CarID { get; set; }
        public string Make { get; set; }

        public int YearOfModel
        {
            get => _yearOfModel;
            set
            {
                _yearOfModel = value;
                NotifyPropertyChanged(nameof(YearOfModel));
            }
        }

        public string Description { get; set; }

        public bool IsDescriptionVisible
        {
            get => _isDescriptionVisible;
            set
            {
                NotifyPropertyChanged(nameof(IsDescriptionVisible));
                _isDescriptionVisible = value;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
    }
}
