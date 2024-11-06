using System.Windows;
using WPFWeather.App.Services;
using WPFWeather.App.ViewModels;

namespace WPFWeather.App.Windows
{
    public partial class MainWindow : Window
    {
        WeatherViewModel viewModel = new WeatherViewModel(new WeatherDiskService());

        public MainWindow()
        {
            InitializeComponent();

            viewModel.DownloadWeatherCommand.Execute("Brno");

            DataContext = viewModel;
        }
    }
}