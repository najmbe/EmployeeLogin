using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EmployeeLogin
{
    public class RelayCommand : ICommand
    {
        private Action<object> _execute;
        private bool _canExecute;
        public RelayCommand(Action<object> execute, bool canExecute = false)
        {
            _execute = execute;
            _canExecute = canExecute;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            
            return _canExecute;
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }
    }
}
