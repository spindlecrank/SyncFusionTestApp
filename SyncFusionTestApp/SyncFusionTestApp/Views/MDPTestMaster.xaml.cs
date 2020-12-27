using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

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

          public class MDPTestMasterViewModel : INotifyPropertyChanged
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
                              }


                         });
                    }
               }
               

               #region INotifyPropertyChanged Implementation
               public event PropertyChangedEventHandler PropertyChanged;
               void OnPropertyChanged([CallerMemberName] string propertyName = "")
               {
                    if (PropertyChanged == null)
                         return;

                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
               }
               #endregion
          }
     }
}