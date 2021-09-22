using System;
using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.UI.Xaml.Controls;
using UeMR.ViewModels;

namespace UeMR.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; }

        public MainPage()
        {
            ViewModel = Ioc.Default.GetService<MainViewModel>();
            InitializeComponent();

            LbVersion.Text = ".NET Core Version: " + Environment.Version + " + OS-Version " + Environment.OSVersion;

        }
    }
}
