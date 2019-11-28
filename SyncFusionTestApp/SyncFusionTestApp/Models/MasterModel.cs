using System;
using System.Collections.Generic;
using System.Text;

namespace SyncFusionTestApp.Models
{
    public class MasterModel : BaseModel
    {
        private string _listName;

        public string ListName
        {
            get => _listName;
            set
            {
                _listName = value;

                OnPropertyChanged("ListName");
            }
        }

        private bool _shared;

        public bool Shared
        {
            get => _shared;
            set
            {
                _shared = value;
                OnPropertyChanged("Shared");
            }
        }

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
    }
}
