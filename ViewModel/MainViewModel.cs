
using CoffeShop.Command;
using CoffeShop.View;
using System;
using System.Diagnostics;
using System.Reflection.Emit;
using System.Threading.Tasks;

namespace CoffeShop.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public  CustomersViewModel CustomersViewModel { get; }
        public ProductsViewModel ProductsViewModel { get; }

        private ViewModelBase? _selectedViewModel;
        public DelegateCommand SelectViewModelCommand { get; }

        public ViewModelBase SelectedViewModel
        {
			get => _selectedViewModel; 
			set { 
				_selectedViewModel = value;
				RaisePropertyChanged();
				}
		}

        public MainViewModel(CustomersViewModel customersViewModel, ProductsViewModel productsViewModel)
        {
            CustomersViewModel = customersViewModel; 
            SelectedViewModel = CustomersViewModel;
            ProductsViewModel = productsViewModel;
            SelectViewModelCommand = new DelegateCommand(SelectViewModel);
        }

        private async void SelectViewModel(object? parameter)
        {
            SelectedViewModel = parameter as ViewModelBase;
            await LoadAsync();
        }

        public async override Task LoadAsync()
        {
            if (SelectedViewModel is not null)
                {
                await SelectedViewModel.LoadAsync();
                }
            }   
    }
}
