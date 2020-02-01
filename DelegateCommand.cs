using System;
using System.Diagnostics;
using System.Windows.Input;

namespace UI4All
{
	public class DelegateCommand : ICommand
	{
		private readonly Action<object> _execute;
		private readonly Action _execute_no;

		private readonly Func<bool> _canExecute;

		/// <summary>
		/// С ПАРАМЕТРАМИ
		/// </summary>

		public DelegateCommand(Action<object> execute) : this(execute, null)
		{

		}

		public DelegateCommand(Action<object> execute, Func<bool> canExecute)
		{
			if(execute == null)
			{
				throw new ArgumentNullException("execute");
			}

			_execute = execute;
			_canExecute = canExecute;
		}


		/// <summary>
		/// БЕЗ ПАРАМЕТРОВ
		/// </summary>

		public DelegateCommand(Action execute_no) : this(execute_no, null)
		{

		}

		public DelegateCommand(Action execute, Func<bool> canExecute)
		{
			if(execute == null)
			{
				throw new ArgumentNullException("execute");
			}

			_execute_no = execute;
			_canExecute = canExecute;
		}

		/// <summary>
		/// Occurs when changes occur that affect whether the command should execute.
		/// </summary>
		public event EventHandler CanExecuteChanged;

		/// <summary>
		/// Raises the <see cref="CanExecuteChanged" /> event.
		/// </summary>
		public void RaiseCanExecuteChanged()
		{
			var handler = CanExecuteChanged;
			if(handler != null)
			{
				handler(this, EventArgs.Empty);
			}
		}

		/// <summary>
		/// Defines the method that determines whether the command can execute in its current state.
		/// </summary>
		/// <param name="parameter">This parameter will always be ignored.</param>
		/// <returns>true if this command can be executed; otherwise, false.</returns>
		[DebuggerStepThrough]
		public bool CanExecute(object parameter)
		{
			return _canExecute == null ? true : _canExecute();
		}

		/// <summary>
		/// Defines the method to be called when the command is invoked. 
		/// </summary>
		/// <param name="parameter">This parameter will always be ignored.</param>
		public void Execute(object parameter)
		{
			if(CanExecute(parameter))
			{
				if(_execute_no == null)
					_execute(parameter);
				else
					_execute_no();
			}
		}
	}
}
