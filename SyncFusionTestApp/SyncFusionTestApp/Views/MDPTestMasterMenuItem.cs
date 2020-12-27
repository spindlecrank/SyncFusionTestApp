using System;
using Xamarin.Forms;

namespace SyncFusionTestApp.Views
{

     public class MDPTestMasterMenuItem
     {
          public MDPTestMasterMenuItem()
          {
               TargetType = typeof(MDPTestMasterMenuItem);
          }
          public int Id { get; set; }
          public string Title { get; set; }
          public FontImageSource IconSource { get; set; }
          public Type TargetType { get; set; }
     }
}