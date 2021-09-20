using CommunityToolkit.Mvvm.DependencyInjection;

using Microsoft.UI.Xaml.Controls;

using UeMR.ViewModels;

namespace UeMR.Views
{
    public sealed partial class VerwaltenPage : Page
    {
        public VerwaltenViewModel ViewModel { get; }

        public VerwaltenPage()
        {
            ViewModel = Ioc.Default.GetService<VerwaltenViewModel>();
            InitializeComponent();
        }
    }
}
