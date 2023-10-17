using CoffeShop.ViewModel;
using System.Windows;
using System.Windows.Controls;
using CoffeShop.ViewModel;
using CoffeShop.Data;

namespace CoffeShop.View
{
   
    public partial class CustomersView : UserControl
    {
        private CustomersViewModel _viewModel;

        public CustomersView()
        {
            InitializeComponent();
            _viewModel = new CustomersViewModel(new CustomerDataProvider());
            DataContext = _viewModel;
            //Loaded += UserControl_Loaded;
        }



        private void ButtonMoveNavigation_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.MoveNavigation();
        }

        private async void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
           await _viewModel.LoadAsync();
        }

        private void btnAddCustomer_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.Add();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
