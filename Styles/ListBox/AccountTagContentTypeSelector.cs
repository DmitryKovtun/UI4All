using System.Windows;
using System.Windows.Controls;
using UI4All.Styles.ListBox.DataTemplates;

namespace UI4All.Styles.ListBox
{
	public class AccountTagContentTypeSelector : DataTemplateSelector
	{

		public DataTemplate AccountContentType { get; set; }

		public DataTemplate FolderDirectoryContentType { get; set; }

		public override DataTemplate SelectTemplate(object item, DependencyObject container)
		{


			if(item is AccountDataTemplate)
				return AccountContentType;

			return null;
		}
	}
}