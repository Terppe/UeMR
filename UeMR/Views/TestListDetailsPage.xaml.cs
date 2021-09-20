using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.WinUI.UI.Controls;

using Microsoft.UI.Xaml.Controls;

using UeMR.ViewModels;

namespace UeMR.Views
{
    public sealed partial class TestListDetailsPage : Page
    {
        public TestListDetailsViewModel ViewModel { get; }

        public TestListDetailsPage()
        {
            ViewModel = Ioc.Default.GetService<TestListDetailsViewModel>();
            InitializeComponent();
        }

        private void OnViewStateChanged(object sender, ListDetailsViewState e)
        {
            if (e == ListDetailsViewState.Both)
            {
                ViewModel.EnsureItemSelected();
            }
        }
    }
}
