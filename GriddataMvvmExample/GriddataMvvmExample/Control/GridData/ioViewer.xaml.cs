using System.Windows;
using System.Windows.Controls;

namespace GriddataMvvmExample.Control.GridData
{
	/// <summary>
	/// ioViewer.xaml에 대한 상호 작용 논리
	/// </summary>
	public partial class ioViewer : UserControl
	{
		public static readonly DependencyProperty ioViewerViewModelProperty
			= DependencyProperty.Register(
				"TempioViewerViewModel",
				typeof(ioViewerViewModel),
				typeof(ioViewer));
		public ioViewerViewModel TempioViewerViewModel
		{
			get { return (ioViewerViewModel)GetValue(ioViewerViewModelProperty); }
			set { SetValue(ioViewerViewModelProperty, value); }
		}

		public ioViewer()
		{
			InitializeComponent();
		}
	}
}
