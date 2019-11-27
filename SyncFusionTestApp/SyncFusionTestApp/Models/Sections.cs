using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SyncFusionTestApp.Models
{
    public class Sections : BaseModel
    {
        #region Properties

        private string _section;

        public string Section
        {
            get => _section;
            set
            {
                _section = value;
                OnPropertyChanged("ListName");
            }
        }

        private int _priority;

        public int Priority
        {
            get => _priority;
            set
            {
                _priority = value;
                OnPropertyChanged("Priority");
            }
        }

        #endregion

        public static Task<List<Sections>> BuildSectionsList()
        {
            var sectionsList = new List<Sections>
            {
                new Sections {Section = "Dairy", Priority = 1},
                new Sections {Section = "Cold Case", Priority = 2}
            };

            return Task.FromResult(sectionsList);
        }
    }
}
