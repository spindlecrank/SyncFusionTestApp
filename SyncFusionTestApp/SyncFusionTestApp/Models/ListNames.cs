using System.Collections.Generic;
using System.Threading.Tasks;

namespace SyncFusionTestApp.Models
{
    public class ListNames : BaseModel
    {
        #region Properties

        private string _listName;

        public string ListName
        {
            get => _listName;
            set
            {
                _listName = value;
                OnPropertyChanged(nameof(ListName));
            }
        }

        private bool _shared;

        public bool Shared
        {
            get => _shared;
            set
            {
                _shared = value;
                OnPropertyChanged(nameof(Shared));
            }
        }

        #endregion

        public static Task<List<ListNames>> BuildNamesList()
        {
            var listNames = new List<ListNames>
            {
                new ListNames {ListName = "Friday", Shared = true},
                new ListNames {ListName = "Sunday", Shared = true}
            };

            return Task.FromResult(listNames);
        }
    }
}
