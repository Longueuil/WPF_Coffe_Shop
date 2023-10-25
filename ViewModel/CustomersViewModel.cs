using CoffeShop.Command;
using CoffeShop.Data;
using CoffeShop.Model;
using CoffeShop.View;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Common;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace CoffeShop.ViewModel
{
    
    public class CustomersViewModel : ViewModelBase
    {
        private readonly ICustomerDataProvider _customerDataProvider;
        private CustomerItemViewModel? _selectedCustomer;
        private NavigationSide _navigationSide;

        public CustomersViewModel(ICustomerDataProvider customerDataProvider)
        {
            _customerDataProvider = customerDataProvider;
            AddCommand = new DelegateCommand(Add);
            MoveNavigationCommand = new DelegateCommand(MoveNavigation);
            DeleteCommand = new DelegateCommand(Delete, CanDelete);
        }

        public ObservableCollection<CustomerItemViewModel> Customers { get; } = new ();
        public CustomerItemViewModel? SelectedCustomer { get => _selectedCustomer;
            set { 
                _selectedCustomer = value; 
                RaisePropertyChanged(); 
                DeleteCommand.RaiseCanExecuteChanged(); 
                RaisePropertyChanged(nameof(IsCustomerSelected));
            } 
        }
        public bool IsCustomerSelected => SelectedCustomer is not null; 

        public NavigationSide NavigationSide { get => _navigationSide; private set { _navigationSide = value; RaisePropertyChanged(); } }

        public DelegateCommand AddCommand { get; }
        public DelegateCommand MoveNavigationCommand { get; }
        public DelegateCommand DeleteCommand { get; }

        public async override Task LoadAsync()
        {
            // check if in Custuments has elements
            if (Customers.Any())
            {
                return;
            }

            var customers = await _customerDataProvider.GetAllAsync();
            if (customers is not null)
            {
                foreach (var customer in customers)
                {
                    Customers.Add(new CustomerItemViewModel(customer));
                }
            }
        }

        private void Add(object? parameter)
        {
            var customer = new Customer { FirstName = "New" };
            var viewModel = new CustomerItemViewModel(customer);
            Customers.Add(viewModel);
            SelectedCustomer = viewModel;
        }

        private void MoveNavigation(object? parameter)
        {
            NavigationSide = NavigationSide == NavigationSide.Left ? NavigationSide.Right : NavigationSide.Left;
        }

        private bool CanDelete(object? arg) => SelectedCustomer is not null;
        private void Delete(object? obj)
        {
           if(SelectedCustomer is not null)
            {
                Customers.Remove(SelectedCustomer);
                SelectedCustomer = null;
            }
        } 
        
    }
    public enum NavigationSide 
    {
        Left,
        Right
    }

}
