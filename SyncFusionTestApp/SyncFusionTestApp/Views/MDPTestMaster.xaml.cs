using System.Collections.ObjectModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SyncFusionTestApp.Views
{
     [XamlCompilation(XamlCompilationOptions.Compile)]
     public partial class MDPTestMaster : ContentPage
     {
          public readonly ListView ListView;

          public MDPTestMaster()
          {
               InitializeComponent();

               BindingContext = new MDPTestMasterViewModel();
               ListView = MenuItemsListView;
          }

          public class MDPTestMasterViewModel
          {
               public ObservableCollection<MDPTestMasterMenuItem> MenuItems { get; set; }

               public MDPTestMasterViewModel()
               {
                    if (Device.RuntimePlatform == Device.iOS)
                    {
                         MenuItems = new ObservableCollection<MDPTestMasterMenuItem>(new[]
                         {
                              new MDPTestMasterMenuItem()
                              {
                                   Id = 0,
                                   Title = "Home",
                                   IconSource = Application.Current.Resources["Home"] as FontImageSource,
                                   TargetType = typeof(MainPage)
                              },
                              new MDPTestMasterMenuItem()
                              {
                                   Id = 1,
                                   Title = "App Info",
                                   IconSource = Application.Current.Resources["Info"] as FontImageSource,
                                   TargetType = typeof(AppInfoView)
                              }
                         });
                    }
               }
          }
     }
}