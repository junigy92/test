using Prism.Mvvm;
using Prism.Commands;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace GriddataMvvmExample.Control.GridData
{
	public class Item : BindableBase
	{
		private int _nNo;
		public int nNo
		{
			get { return _nNo; }
			set { _nNo = value; RaisePropertyChanged(); }
		}
		private string _szDescription = "";
		public string szDescription
		{
			get { return _szDescription; }
			set { _szDescription = value; RaisePropertyChanged(); }
		}
		private bool _bStatus;
		public bool bStatus
		{
			get { return _bStatus; }
			set { _bStatus = value; RaisePropertyChanged(); }
		}
	}
	public class ioViewerViewModel : BindableBase
	{
		private string _LabelContent;
		public string LabelContent
		{
			get => _LabelContent;
			set => SetProperty(ref _LabelContent, value);
		}
		public ObservableCollection<Item> GridRawData { get; set; }
		public ICommand ICommandStatus { get; set; }
		public ioViewerViewModel()
		{
			// 초기값 설정
			LabelContent = "default";
			GridRawData = new();
			ICommandStatus = new DelegateCommand<object>(OnPropertyChanged);
		}
		public void Init()
		{
			for (int num = 0; num < 32; num++)
				GridRawData.Add(new Item());
		}
		private void OnPropertyChanged(object param)
		{
			int index = GridRawData.IndexOf(param as Item);

			if (true == GridRawData[index].bStatus)
				GridRawData[index].bStatus = false;
			else
				GridRawData[index].bStatus = true;
		}
	}
}
