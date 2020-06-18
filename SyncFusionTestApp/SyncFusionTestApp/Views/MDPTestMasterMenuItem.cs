using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

          public Type TargetType { get; set; }
     }
}