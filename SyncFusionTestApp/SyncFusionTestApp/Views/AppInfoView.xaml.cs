using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SyncFusionTestApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppInfoView : ContentPage
    {
        public readonly string AppVersionInfo;
        public readonly string AppBuildInfo;

        public AppInfoView()
        {
            InitializeComponent();

            BindingContext = this;

            AppVersionInfo = Xamarin.Essentials.AppInfo.VersionString;
            AppBuildInfo = Xamarin.Essentials.AppInfo.BuildString;

            AppVersionLabel.Text = $"App Version: {AppVersionInfo}, Build: {AppBuildInfo}";
        }

        private void SettingsInfoButton_OnClicked(object sender, EventArgs e)
        {
            // Display settings page
            Xamarin.Essentials.AppInfo.ShowSettingsUI();
        }
    }
}