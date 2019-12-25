using Syncfusion.ListView.XForms.UWP;
using Syncfusion.SfPullToRefresh.XForms.UWP;

namespace SyncFusionTestApp.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();
            SfPullToRefreshRenderer.Init();
            SfListViewRenderer.Init();

            LoadApplication(new SyncFusionTestApp.App());
        }
    }
}
