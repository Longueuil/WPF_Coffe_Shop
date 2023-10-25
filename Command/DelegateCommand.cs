using CoffeShop.View;
using System;
using System.Windows.Input;

namespace CoffeShop.Command
{
    public class DelegateCommand : ICommand
    {
        private readonly Action<object?> _execute;
        private readonly Func<object?, bool>? _canExecute;
        private ViewModelBase selectedViewModel;

        public DelegateCommand(Action<object?> execute, Func<object?, bool>? canExecute = null)
        {
            ArgumentNullException.ThrowIfNull(execute);
            _execute = execute;
            _canExecute = canExecute;
        }

        public DelegateCommand(ViewModelBase selectedViewModel)
        {
            this.selectedViewModel = selectedViewModel;
        }

        public void RaiseCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter) => _canExecute is null ? true : _canExecute(parameter);
        

        public void Execute(object? parameter) => _execute(parameter);
        
    }
}
