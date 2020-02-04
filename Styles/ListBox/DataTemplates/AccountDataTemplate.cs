using System.Windows;
using System.Windows.Input;

namespace UI4All.Styles.ListBox.DataTemplates
{
	public class AccountDataTemplate : NotifyPropertyChanged
	{

		#region fields
		//public static FileSelectionWindow mwvm = null;

		public static int SymbolsToShow = 40;

		private string _website = "null";

		public string Website
		{
			get { return _website; }
			set
			{
				if(value.Length > SymbolsToShow)
				{
					_website = value.Remove(SymbolsToShow) + "...";
				}
				else
					_website = value;
				OnPropertyChanged("Name");
			}
		}

		private double _ElementOpacity = 1;

		public double ElementOpacity
		{
			get { return _ElementOpacity; }
			set
			{
				_ElementOpacity = value;
				OnPropertyChanged("ElementOpacity");
			}
		}

		private bool _ElementIsEnabled = true;

		public bool ElementIsEnabled
		{
			get { return _ElementIsEnabled; }
			set
			{
				_ElementIsEnabled = value;
				OnPropertyChanged("ElementIsEnabled");
			}
		}


		#endregion


		public void SwitchEnabled()
		{
			ElementIsEnabled = !ElementIsEnabled;
		}


		public AccountDataTemplate()
		{

		}


		public AccountDataTemplate(string website) : this()
		{
			Website = website;
		}



		#region commands





		private ICommand _ItemCLickCommand;

		public virtual ICommand ItemCLickCommand
		{
			get
			{
				if(_ItemCLickCommand == null)
					_ItemCLickCommand = new DelegateCommand(delegate ()
					{

						MessageBox.Show("ItemCLickCommand");
					});
				return _ItemCLickCommand;
			}
		}


		private ICommand _OpenBackupItemWindowCommand;

		public virtual ICommand OpenBackupItemWindowCommand
		{
			get
			{
				if(_OpenBackupItemWindowCommand == null)
					_OpenBackupItemWindowCommand = new DelegateCommand(delegate ()
					{


						MessageBox.Show("OpenBackupItemWindowCommand");
					});
				return _OpenBackupItemWindowCommand;
			}
		}


		private ICommand _GetInfoAboutItemCommand;

		public virtual ICommand GetInfoAboutItemCommand
		{
			get
			{
				if(_GetInfoAboutItemCommand == null)
					_GetInfoAboutItemCommand = new DelegateCommand(delegate ()
					{
						MessageBox.Show("GetInfoAboutItemCommand");


					});
				return _GetInfoAboutItemCommand;
			}
		}



		private ICommand _RemoveItemCommand;

		public ICommand RemoveItemCommand
		{
			get
			{
				if(_RemoveItemCommand == null)
					_RemoveItemCommand = new DelegateCommand(delegate ()
					{



					});
				return _RemoveItemCommand;
			}
		}

		#endregion

	}
}

