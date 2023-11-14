using GriddataMvvmExample.Control.GridData;
using Prism.Mvvm;

namespace GriddataMvvmExample.ViewModel
{
	public class TestPageViewModel : BindableBase
	{
		private ioViewerViewModel _Input1;
		public ioViewerViewModel Input1
		{
			get { return _Input1; }
			set { SetProperty(ref _Input1, value); }
		}
		public TestPageViewModel()
		{
			Input1 = new ioViewerViewModel();
			//Input1.LabelContent = "Input I/O";
			Input1.Init();
		}
	}
}
