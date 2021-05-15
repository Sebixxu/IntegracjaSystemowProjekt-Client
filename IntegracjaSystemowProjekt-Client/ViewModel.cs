using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using IntegracjaSystemowProjekt_Client.Annotations;
using IntegracjaSystemowProjekt_Client.WCFServiceST;

namespace IntegracjaSystemowProjekt_Client
{
    internal class ViewModel : INotifyPropertyChanged
    {
        //Data received
        private int _laptopCountByManufacturer;
        private int _laptopCountByScreenAspectRatio;
        private IEnumerable<Laptop> _laptops;

        public IEnumerable<Laptop> Laptops
        {
            get => _laptops;
            set
            {
                _laptops = value;
                OnPropertyChanged(nameof(Laptops));
            }
        }

        public int LaptopCountByManufacturer
        {
            get => _laptopCountByManufacturer;
            set
            {
                _laptopCountByManufacturer = value;
                OnPropertyChanged(nameof(LaptopCountByManufacturer));
            }
        }

        public int LaptopCountByScreenAspectRatio
        {
            get => _laptopCountByScreenAspectRatio;
            set
            {
                _laptopCountByScreenAspectRatio = value;
                OnPropertyChanged(nameof(LaptopCountByScreenAspectRatio));
            }
        }

        //Combo boxes
        public IEnumerable<string> ManufacturerNames { get; set; }
        public IEnumerable<string> AspectRatios { get; set; }
        public IEnumerable<string> ScreenTypes { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}