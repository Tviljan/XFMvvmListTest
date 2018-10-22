using System;
using CarsExample.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace CarsExample.ViewModels
{

    public class CarsViewModel : INotifyPropertyChanged
    {

        // We are using ObservableCollection because:
        // When an object is added to or removed from an observable collection, the UI is automatically updated.
        private ObservableCollection<Car> items;
        public ObservableCollection<Car> Items
        {
            get { return items; }
            set
            {
                items = value;
            }
        }


        Car _selectedItem;

        public event PropertyChangedEventHandler PropertyChanged;

        public Car SelectedItem
        {
            get
            {
                return _selectedItem;
            }

            set
            {
                _selectedItem = value;
                _selectedItem.YearOfModel++;
                _selectedItem.IsDescriptionVisible = !_selectedItem.IsDescriptionVisible;
                NotifyPropertyChanged("SelectedItem");

            }
        }

        public CarsViewModel()
        {

            // Here you can have your data form db or something else,
            // some data that you already have to put in the list
            Items = new ObservableCollection<Car>() {
                new Car()
                {
                    IsDescriptionVisible = false,
                    CarID = 1,
                    Make = "Sports car",
                    Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem. Nulla consequat massa quis enim. Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis eu pede mollis pretium. Integer tincidunt. Cras dapibus. Vivamus elementum semper nisi. Aenean vulputate eleifend tellus. Aenean leo ligula, porttitor eu, consequat vitae",
                    YearOfModel = 2015
                },
                  new Car()
                {
                    IsDescriptionVisible = false,
                    CarID = 2,
                    Make = "Toy car",
                    Description = "Some bit longer text with fii faa fou",
                    YearOfModel = 2012
                },new Car()
                {
                    IsDescriptionVisible = false,
                    CarID = 3,
                    Make = "Family car",
                    Description = "This is some kind of long text descriping the car",
                    YearOfModel = 2012
                },new Car()
                {
                    IsDescriptionVisible = false,
                    CarID = 3,
                    Make = "Future car",
                    Description = "This is some kind of long text descriping the car FROM THE FUTURE!!!",
                    YearOfModel = 2022
                }

            };


        }

        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
    }
}