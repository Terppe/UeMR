using CommunityToolkit.Mvvm.DependencyInjection;

using Microsoft.UI.Xaml.Controls;

using UeMR.ViewModels;

namespace UeMR.Views
{
    public sealed partial class EinrichtenPage : Page
    {
        public EinrichtenViewModel ViewModel { get; }

        public EinrichtenPage()
        {
            ViewModel = Ioc.Default.GetService<EinrichtenViewModel>();
            InitializeComponent();
        }
    }
}
