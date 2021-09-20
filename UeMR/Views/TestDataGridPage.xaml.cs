using CommunityToolkit.Mvvm.DependencyInjection;

using Microsoft.UI.Xaml.Controls;

using UeMR.ViewModels;

namespace UeMR.Views
{
    // TODO WTS: Change the grid as appropriate to your app, adjust the column definitions on DataGridPage.xaml.
    // For more details see the documentation at https://docs.microsoft.com/windows/communitytoolkit/controls/datagrid
    public sealed partial class TestDataGridPage : Page
    {
        public TestDataGridViewModel ViewModel { get; }

        public TestDataGridPage()
        {
            ViewModel = Ioc.Default.GetService<TestDataGridViewModel>();
            InitializeComponent();
        }
    }
}
