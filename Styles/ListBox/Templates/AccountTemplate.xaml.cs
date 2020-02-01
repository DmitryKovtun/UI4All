using System.ComponentModel;
using System.Windows.Controls;

namespace UI4All.Styles.ListBox.Templates
{
	/// <summary>
	/// Interaction logic for AccountTemplate.xaml
	/// </summary>
	public partial class AccountTemplate : UserControl, INotifyPropertyChanged
	{
		public AccountTemplate()
		{
			InitializeComponent();
		}

		#region INotifyPropertyChanged implementation

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}


		#endregion
	}
}