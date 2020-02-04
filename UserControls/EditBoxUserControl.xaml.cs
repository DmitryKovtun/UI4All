using System.Windows.Controls;

namespace UI4All.UserControls
{
	/// <summary>
	/// Interaction logic for EditBoxUserControl.xaml
	/// </summary>
	public partial class EditBoxUserControl : UserControl
	{
		public EditBoxUserControl()
		{
			InitializeComponent();
		}

		public void Execute()
		{
			AddButton.Command?.Execute(UnifiedTextBox.Text);
		}

	}
}
