using System.Collections;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace UI4All.Styles.ListBox
{
	/// <summary>
	/// Interaction logic for AccountTagListBox.xaml
	/// </summary>
	public partial class AccountListBoxControl : UserControl
	{
		public AccountListBoxControl()
		{
			InitializeComponent();
			//DataContext = this;
			//Main.DataContext = DataContext;
			//DataContext
		}


		public IEnumerable ItemsSource
		{
			get { return Main.ItemsSource; }
			set { Main.ItemsSource = value; }
		}




		private ICommand _ItemCLickCommand;

		public virtual ICommand ItemCLickCommand
		{
			get
			{
				if(_ItemCLickCommand == null)
					_ItemCLickCommand = new DelegateCommand(delegate ()
					{

						MessageBox.Show("Texccxcxcxcxxccxcxcxst");
					});
				return _ItemCLickCommand;
			}
		}
	}
}
