using CommunityToolkit.Mvvm.DependencyInjection;

using Microsoft.UI.Xaml.Controls;

using UeMR.ViewModels;

namespace UeMR.Views
{
    public sealed partial class EmpfangenPage : Page
    {
        public EmpfangenViewModel ViewModel { get; }

        public EmpfangenPage()
        {
            ViewModel = Ioc.Default.GetService<EmpfangenViewModel>();
            InitializeComponent();
        }
    }
}
