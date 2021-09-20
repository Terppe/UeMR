using CommunityToolkit.Mvvm.DependencyInjection;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.UI.Xaml;

using UeMR.Activation;
using UeMR.Contracts.Services;
using UeMR.Core.Contracts.Services;
using UeMR.Core.Services;
using UeMR.Helpers;
using UeMR.Services;
using UeMR.ViewModels;
using UeMR.Views;

// To learn more about WinUI3, see: https://docs.microsoft.com/windows/apps/winui/winui3/.
namespace UeMR
{
    public partial class App : Application
    {
        public static Window MainWindow { get; set; } = new Window() { Title = "AppDisplayName".GetLocalized() };

        public App()
        {
            InitializeComponent();
            UnhandledException += App_UnhandledException;
            Ioc.Default.ConfigureServices(ConfigureServices());
        }

        private void App_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            // TODO WTS: Please log and handle the exception as appropriate to your scenario
            // For more info see https://docs.microsoft.com/windows/winui/api/microsoft.ui.xaml.unhandledexceptioneventargs
        }

        protected override async void OnLaunched(LaunchActivatedEventArgs args)
        {
            base.OnLaunched(args);
            var activationService = Ioc.Default.GetService<IActivationService>();
            await activationService.ActivateAsync(args);
        }

        private System.IServiceProvider ConfigureServices()
        {
            // TODO WTS: Register your services, viewmodels and pages here
            var services = new ServiceCollection();

            // Default Activation Handler
            services.AddTransient<ActivationHandler<LaunchActivatedEventArgs>, DefaultActivationHandler>();

            // Other Activation Handlers

            // Services
            services.AddSingleton<IThemeSelectorService, ThemeSelectorService>();
            services.AddTransient<INavigationViewService, NavigationViewService>();

            services.AddSingleton<IActivationService, ActivationService>();
            services.AddSingleton<IPageService, PageService>();
            services.AddSingleton<INavigationService, NavigationService>();

            // Core Services
            services.AddSingleton<ISampleDataService, SampleDataService>();

            // Views and ViewModels
            services.AddTransient<ShellPage>();
            services.AddTransient<ShellViewModel>();
            services.AddTransient<MainViewModel>();
            services.AddTransient<MainPage>();
            services.AddTransient<EinrichtenViewModel>();
            services.AddTransient<EinrichtenPage>();
            services.AddTransient<EmpfangenViewModel>();
            services.AddTransient<EmpfangenPage>();
            services.AddTransient<VerwaltenViewModel>();
            services.AddTransient<VerwaltenPage>();
            services.AddTransient<TestListDetailsViewModel>();
            services.AddTransient<TestListDetailsPage>();
            services.AddTransient<TestContentGridViewModel>();
            services.AddTransient<TestContentGridPage>();
            services.AddTransient<TestContentGridDetailViewModel>();
            services.AddTransient<TestContentGridDetailPage>();
            services.AddTransient<TestDataGridViewModel>();
            services.AddTransient<TestDataGridPage>();
            services.AddTransient<SettingsViewModel>();
            services.AddTransient<SettingsPage>();
            return services.BuildServiceProvider();
        }
    }
}
