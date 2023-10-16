using System.Windows;
using System.Windows.Controls;

namespace CoffeShop.View
{
   
    public partial class CustomersView : UserControl
    {
        public CustomersView()
        {
            InitializeComponent();
        }
        private void ButtonMoveNavigation_Click(object sender, RoutedEventArgs e)
        {
            var column = Grid.GetColumn(gridCustomerList);

            var newColumn = column == 0 ? 2 : 0;

            Grid.SetColumn(gridCustomerList, newColumn);
        }
    }
}
