using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using IntegracjaSystemowProjekt_Client.WCFServiceST;


namespace IntegracjaSystemowProjekt_Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ViewModel viewModel;
        private static LaptopServiceClient _laptopServiceClient;

        public MainWindow()
        {
            InitializeComponent();

            viewModel = new ViewModel();

            TrySetupConnectionWithServer();

            viewModel.ManufacturerNames = _laptopServiceClient.GetListOfManufacturerNames();
            viewModel.AspectRatios = _laptopServiceClient.GetListOfScreenAspectRatios();
            viewModel.ScreenTypes = _laptopServiceClient.GetListOfScreenSurfaceTypes();

            DataContext = viewModel;
        }

        private void TrySetupConnectionWithServer()
        {
            try
            {
                _laptopServiceClient = new LaptopServiceClient();
                _laptopServiceClient.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show($"Wystąpił błąd podczas łączenia z serwerm, aplikacja zostanie zamknięta.\nStack trace:\n{e}", "Błąd", 
                    MessageBoxButton.OK, MessageBoxImage.Error);
                Console.WriteLine(e);

                System.Windows.Application.Current.Shutdown();
                throw;
            }
            
            if (_laptopServiceClient.State == CommunicationState.Opened)
                MessageBox.Show("Połączono z serwerem.", "Informacja", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void GetLaptopCountByManufacturerFromServer(object sender, RoutedEventArgs e)
        {
            string pickedManufacturerName;

            if (ManufacturerNamesComboBox.SelectedItem != null)
                pickedManufacturerName = ManufacturerNamesComboBox.SelectedItem.ToString();
            else
                return;

            if (pickedManufacturerName == "<brak wartości>")
                pickedManufacturerName = String.Empty;
            var laptopCountByManufacturer = _laptopServiceClient.GetLaptopCountByManufacturer(pickedManufacturerName);

            viewModel.LaptopCountByManufacturer = laptopCountByManufacturer;
        }

        private void GetLaptopCountByScreenAspectRatioFromServer(object sender, RoutedEventArgs e)
        {
            string pickedAspectRatio;

            if (AspectRatiosComboBox.SelectedItem != null)
                pickedAspectRatio = AspectRatiosComboBox.SelectedItem.ToString();
            else
                return;

            if (pickedAspectRatio == "<brak wartości>")
                pickedAspectRatio = String.Empty;
            var laptopCountByScreenAspectRatio = _laptopServiceClient.GetLaptopCountByScreenAspectRatio(pickedAspectRatio);

            viewModel.LaptopCountByScreenAspectRatio = laptopCountByScreenAspectRatio;
        }

        private void GetLaptopsByScreenTypeFromServer(object sender, RoutedEventArgs e)
        {
            string pickedScreenType;

            if (ScreenTypesComboBox.SelectedItem != null)
                pickedScreenType = ScreenTypesComboBox.SelectedItem.ToString();
            else
                return;

            if(pickedScreenType == "<brak wartości>")
                pickedScreenType = String.Empty;
            var laptopsResponse = _laptopServiceClient.GetLaptopsByScreenType(pickedScreenType);

            if (laptopsResponse.State == ResponseState.OK)
            {
                viewModel.Laptops = laptopsResponse.Laptops.Select(x => new Laptop
                {
                    ScreenDiagonal = x.ScreenDiagonal,
                    Resolution = x.Resolution,
                    ManufacturerName = x.ManufacturerName,
                    DiskType = x.DiskType,
                    DiskSize = x.DiskSize,
                    Vram = x.Vram,
                    Ram = x.Ram,
                    Drive = x.Drive,
                    Gpu = x.Gpu,
                    Os = x.Os,
                    ProcessorName = x.ProcessorName,
                    ScreenSurfaceType = x.ScreenSurfaceType,
                    IsTouchable = x.IsTouchable,
                    Frequency = x.Frequency,
                    NumberOfPhysicalCores = x.NumberOfPhysicalCores
                });

                MessageBox.Show("Pobrano dane z serwera.", "Informacja", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else if (laptopsResponse.State == ResponseState.NotFound)
                MessageBox.Show("Nie znaleziono laptopów.", "Informacja", MessageBoxButton.OK, MessageBoxImage.Information);
            else
                MessageBox.Show("Wystąpił błąd.", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
