using CoffeShop.ViewModel;
using CoffeShop.Data;
using System.Windows;
using System;

namespace CoffeShop
{
    public partial class MainWindow : Window
    {
        private readonly MainViewModel _viewModel;

        public MainWindow(MainViewModel viewModel)
        {
            //   _viewModel = new MainViewModel(new CustomersViewModel(new CustomerDataProvider()), new ProductsViewModel());
            InitializeComponent();
            _viewModel = viewModel;
               DataContext = _viewModel;
            Loaded += MainWindow_Loaded;
        }

        private async void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            await _viewModel.LoadAsync();
        }
    }
}
