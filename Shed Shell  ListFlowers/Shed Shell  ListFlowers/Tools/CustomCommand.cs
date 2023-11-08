using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Shed_Shell__ListFlowers.Tools
{
    public class CustomCommand<T> : ICommand
    {
        public CustomCommand(Action<T> action)
        {
            this.action = action;
        }

        Action<T> action {  get; set; }    
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            action((T)parameter);
        }
    }
}
