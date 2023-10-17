using CoffeShop.Model;
using CoffeShop.View;
using System.Security.AccessControl;

namespace CoffeShop.ViewModel
{
    public class CustomerItemViewModel :ViewModelBase
    {
        private Customer _model;

        public CustomerItemViewModel(Customer model)
        {
            _model = model;
        }
        public int Id => _model.Id;

        public string? FirstName
        {
            get => _model.FirstName;
            set { _model.FirstName = value;
                RaisePropertyChanged(); }
        }
        public string? LastName
        {
            get => _model.LastName;
            set
            {
                _model.LastName = value;
                RaisePropertyChanged();
            }
        }
        public bool IsDeveloper
        {
            get => _model.IsDeveloper;
            set
            {
                _model.IsDeveloper = value;
                RaisePropertyChanged();
            }
        }
    }
}
