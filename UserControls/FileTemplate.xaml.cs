using System.ComponentModel;
using System.Windows.Controls;

namespace UI4All.UserControls
{
	/// <summary>
	/// Interaction logic for FileTemplate.xaml
	/// </summary>
	public partial class FileTemplate : UserControl, INotifyPropertyChanged
	{
		public FileTemplate()
		{
			this?.InitializeComponent();



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
