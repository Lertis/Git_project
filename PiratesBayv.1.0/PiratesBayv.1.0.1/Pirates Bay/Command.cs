using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Pirates_Bay
{
    class Command:ICommand
    {
        public Func<bool> CanExecuteDelegate { get; set; }
        public Action ExecuteDelegate { get; set; }
        public Command(Func<bool> canExecute, Action execute)
        {
            CanExecuteDelegate = canExecute;
            ExecuteDelegate = execute;
        }
        public bool CanExecute(object parameter)
        {
            return CanExecuteDelegate != null ? CanExecuteDelegate() : true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            ExecuteDelegate();
        }
    }
}
