using System.Windows.Input;

namespace UI4All.Styles.ListBox
{
	public class FileDirectoryContentType : NotifyPropertyChanged
	{

		#region fields
		//public static FileSelectionWindow mwvm = null;


		public static int SymbolsToShow = 40;

		private string _name = "null";

		public string Name
		{
			get { return _name; }
			set
			{
				if(value.Length > SymbolsToShow)
				{
					_name = value.Remove(SymbolsToShow) + "...";
				}
				else
					_name = value;
				OnPropertyChanged("Name");
			}
		}




		private string _fileType = "null";

		public string FileType
		{
			get { return _fileType; }
			set
			{
				_fileType = value;
				OnPropertyChanged("FileType");
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




		private string _fullpath = "null";

		public string FullPath
		{
			get { return _fullpath; }
			set
			{
				_fullpath = value;
				OnPropertyChanged("FullPath");
			}
		}




		#endregion


		public void SwitchEnabled()
		{
			ElementIsEnabled = !ElementIsEnabled;
		}





		public FileDirectoryContentType()
		{

		}


		public FileDirectoryContentType(string name) : this()
		{
			Name = name;
		}


		public FileDirectoryContentType(string name, string type) : this(name)
		{
			FileType = type;
		}


		public FileDirectoryContentType(string name, string type, string fullpath) : this(name, type)
		{
			FullPath = fullpath;
		}




		#region commands

		public virtual ICommand LeftCLickCommand { get; }

		public virtual ICommand LeftCLickSecondCommand { get; }

		public virtual ICommand RightCLickCommand { get; }
		
		public virtual ICommand RightCLickSecondCommand { get; }

		public virtual ICommand RemoveItemCommand { get; }

		#endregion

















	}
}
