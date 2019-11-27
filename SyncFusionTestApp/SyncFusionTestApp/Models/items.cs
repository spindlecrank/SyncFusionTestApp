using System.Collections.Generic;
using System.Threading.Tasks;

namespace SyncFusionTestApp.Models
{
    public class Items : BaseModel
    {
        #region Properties

        private string _name;

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }
        private string _unitOfIssue;

        public string UnitOfIssue
        {
            get => _unitOfIssue;
            set
            {
                _unitOfIssue = value;
                OnPropertyChanged("UnitOfIssue");
            }
        }

        private string _description;

        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged("Description");
            }
        }

        #endregion

        public static Task<List<Items>> BuildItemsList()
        {
            var itemsList = new List<Items>
            {
                new Items {Name = "Bleach", UnitOfIssue = "Jug", Description = "Clorox 2"},
                new Items {Name = "Laundry Detergent", UnitOfIssue = "Jug", Description = "Tide Free and Clear"}
            };

            return Task.FromResult(itemsList);
        }
    }
}
