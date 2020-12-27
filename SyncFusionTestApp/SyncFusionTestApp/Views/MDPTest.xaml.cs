using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SyncFusionTestApp.Views
{
     [XamlCompilation(XamlCompilationOptions.Compile)]
     public partial class MDPTest : MasterDetailPage
     {
          public MDPTest()
          {
               InitializeComponent();
               MasterPage.ListView.ItemSelected += ListView_ItemSelected;

               MasterBehavior = MasterBehavior.Popover;
          }

          private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
          {
               if (!(e.SelectedItem is MDPTestMasterMenuItem item))
                    return;
               
               var page = (Page)Activator.CreateInstance(item.TargetType);
               
               page.Title = item.Title;

               Detail = new NavigationPage(page);
               
               IsPresented = false;

               MasterPage.ListView.SelectedItem = null;
          }
     }
}