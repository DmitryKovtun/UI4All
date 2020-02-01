using System.Collections;
using System.Windows.Controls;

namespace UI4All.Styles.ListBox
{
	/// <summary>
	/// Interaction logic for AccountTagListBox.xaml
	/// </summary>
	public partial class AccountTagListBox : UserControl
	{
		public AccountTagListBox()
		{
			InitializeComponent();
		}



		public IEnumerable ItemsSource
		{
			get { return Main.ItemsSource; }
			set { Main.ItemsSource = value; }
		}

		
	}
}
