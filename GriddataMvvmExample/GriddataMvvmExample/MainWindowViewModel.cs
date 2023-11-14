using Prism.Mvvm;

namespace GriddataMvvmExample.ViewModel
{
	internal class MainWindowViewModel : BindableBase
	{
		private object _currentView;
		public object CurrentView
		{
			get => _currentView;
			set { _currentView = value; RaisePropertyChanged("CurrentView"); }
		}
		public MainWindowViewModel()
		{
			CurrentView = new TestPageViewModel();
		}
	}
}
