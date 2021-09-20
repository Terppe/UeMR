using CommunityToolkit.Mvvm.DependencyInjection;

using Microsoft.UI.Xaml.Controls;

using UeMR.ViewModels;

namespace UeMR.Views
{
    public sealed partial class TestContentGridPage : Page
    {
        public TestContentGridViewModel ViewModel { get; }

        public TestContentGridPage()
        {
            ViewModel = Ioc.Default.GetService<TestContentGridViewModel>();
            InitializeComponent();
        }
    }
}
