using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FCalendar.ViewModel
{
	public class RelayCommand:ICommand

	{
		private readonly Action _execute;
		private readonly Func<bool> _canExecute;

		public bool CanExecute(object parameter)
		{
			return _canExecute == null ? true : _canExecute();
		}

		public void Execute(object parameter)
		{
			_execute();
		}

		public event EventHandler CanExecuteChanged;
		public RelayCommand(Action execute)
			: this(execute, null)
		{
		}

		private RelayCommand(Action execute, Func<bool> canExecute)
		{
			if (execute == null)
				throw new ArgumentException("excute");
			_execute = execute;
			_canExecute = canExecute;
			{

			}
		}
		public void RaiseCanExecuteChanged()
		{
			var handler = CanExecuteChanged;
			if (handler != null)
			{
				handler(this, EventArgs.Empty);
			}
		}
	}
}
