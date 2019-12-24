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

        private string _name;

        public string Name
        {
            get => _name;
            set
            {
                _name = value;

                OnPropertyChanged(nameof(Name));
            }
        }
        private string _unitOfIssue;

        public string UnitOfIssue
        {
            get => _unitOfIssue;
            set
            {
                _unitOfIssue = value;
                OnPropertyChanged(nameof(UnitOfIssue));
            }
        }

        private string _description;

        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
            }
        }

        private string _section;

        public string Section
        {
            get => _section;
            set
            {
                _section = value;

                OnPropertyChanged(nameof(ListName));
            }
        }

        private int _priority;

        public int Priority
        {
            get => _priority;
            set
            {
                _priority = value;
                OnPropertyChanged(nameof(Priority));
            }
        }
    }
}
