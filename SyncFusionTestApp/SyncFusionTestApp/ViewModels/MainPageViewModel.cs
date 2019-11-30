using SyncFusionTestApp.Models;

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SyncFusionTestApp.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        #region Properties and Fields

        private bool testBool = false;

        private string _listName;

        public string ListName
        {
            get => _listName;
            set
            {
                _listName = value;

                if (string.IsNullOrEmpty(_listName))
                    _listName = "Select a list to view...";

                MasterModel = new MasterModel
                {
                    ListName = ListName,
                    Shared = Shared,
                    Name = Name,
                    UnitOfIssue = UnitOfIssue,
                    Description = Description,
                    Section = Section,
                    Priority = Priority
                };

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

                MasterModel = new MasterModel
                {
                    ListName = ListName,
                    Shared = Shared,
                    Name = Name,
                    UnitOfIssue = UnitOfIssue,
                    Description = Description,
                    Section = Section,
                    Priority = Priority
                };

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

                if (string.IsNullOrEmpty(_name))
                    _name = "Pick an Item...";

                MasterModel = new MasterModel
                {
                    ListName = ListName,
                    Shared = Shared,
                    Name = Name,
                    UnitOfIssue = UnitOfIssue,
                    Description = Description,
                    Section = Section,
                    Priority = Priority
                };

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

                MasterModel = new MasterModel
                {
                    ListName = ListName,
                    Shared = Shared,
                    Name = Name,
                    UnitOfIssue = UnitOfIssue,
                    Description = Description,
                    Section = Section,
                    Priority = Priority
                };

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

                MasterModel = new MasterModel
                {
                    ListName = ListName,
                    Shared = Shared,
                    Name = Name,
                    UnitOfIssue = UnitOfIssue,
                    Description = Description,
                    Section = Section,
                    Priority = Priority
                };

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

                if (string.IsNullOrEmpty(_section))
                    _section = "Pick a Section...";

                MasterModel = new MasterModel
                {
                    ListName = ListName,
                    Shared = Shared,
                    Name = Name,
                    UnitOfIssue = UnitOfIssue,
                    Description = Description,
                    Section = Section,
                    Priority = Priority
                };

                OnPropertyChanged("Section");
            }
        }

        private int _priority;

        public int Priority
        {
            get => _priority;
            set
            {
                _priority = value;

                MasterModel = new MasterModel
                {
                    ListName = ListName,
                    Shared = Shared,
                    Name = Name,
                    UnitOfIssue = UnitOfIssue,
                    Description = Description,
                    Section = Section,
                    Priority = Priority
                };

                OnPropertyChanged("Priority");
            }
        }

        private bool _showMe;

        public bool ShowMe
        {
            get => _showMe;
            set
            {
                _showMe = value;
                OnPropertyChanged("ShowMe");
            }
        }

        private ListNames _listNames;

        public ListNames ListNames
        {
            get => _listNames;
            set
            {
                _listNames = value;

                if (ListNames != null)
                {
                    ListName = _listNames.ListName;
                    Shared = _listNames.Shared;
                }

                MasterModel = new MasterModel
                {
                    ListName = ListName,
                    Shared = Shared,
                    Name = Name,
                    UnitOfIssue = UnitOfIssue,
                    Description = Description,
                    Section = Section,
                    Priority = Priority
                };

                OnPropertyChanged("ListNames");
            }
        }


        private Items _items;

        public Items Items
        {
            get => _items;
            set
            {
                _items = value;

                if (Items != null)
                {
                    Name = _items.Name;
                    UnitOfIssue = _items.UnitOfIssue;
                    Description = _items.Description;
                }

                MasterModel = new MasterModel
                {
                    ListName = ListName,
                    Shared = Shared,
                    Name = Name,
                    UnitOfIssue = UnitOfIssue,
                    Description = Description,
                    Section = Section,
                    Priority = Priority
                };

                OnPropertyChanged("Items");
            }
        }

        private Sections _sections;

        public Sections Sections
        {
            get => _sections;
            set
            {
                _sections = value;

                if (Sections != null)
                {
                    Section = _sections.Section;
                    Priority = _sections.Priority;
                }

                MasterModel = new MasterModel
                {
                    ListName = ListName,
                    Shared = Shared,
                    Name = Name,
                    UnitOfIssue = UnitOfIssue,
                    Description = Description,
                    Section = Section,
                    Priority = Priority
                };

                OnPropertyChanged("Sections");
            }
        }

        private MasterModel _masterModel;

        public MasterModel MasterModel
        {
            get => _masterModel;
            set
            {
                _masterModel = value;
                OnPropertyChanged("MasterModel");
            }
        }



        private readonly List<Colors> _subColors = new List<Colors>();
        private List<ListNames> _namesList = new List<ListNames>();
        private List<Items> _itemsList = new List<Items>();
        private List<Sections> _sectionsList = new List<Sections>();
        private List<MasterModel> _masterModelList = new List<MasterModel>();

        public ObservableCollection<Colors> ColorsObservableCollection { get; set; }
        public ObservableCollection<ListNames> ListNamesObservableCollection { get; set; }
        public ObservableCollection<Items> ItemsObservableCollection { get; set; }
        public ObservableCollection<Sections> SectionsObservableCollection { get; set; }
        public ObservableCollection<MasterModel> MasterModelObservableCollection { get; set; }
        
        #endregion
        #region CTOR

        public MainPageViewModel()
        {
            ColorsObservableCollection = new ObservableCollection<Colors>();
            ListNamesObservableCollection = new ObservableCollection<ListNames>();
            ItemsObservableCollection = new ObservableCollection<Items>();
            SectionsObservableCollection = new ObservableCollection<Sections>();
            MasterModelObservableCollection = new ObservableCollection<MasterModel>();

            Name = null;
            Section = null;
        }

        #endregion
        #region Public Methods

        public async Task BuildAllListsAsync()
        {
            await BuildListNamesAsync();
            await BuildItemsAsync();
            await BuildSectionsAsync();
            BuildColorsList();
        }

        public void DoUpdate(Colors item)
        {
            int index = ColorsObservableCollection.IndexOf(item);

            ColorsObservableCollection.Remove(item);

            if (item.BgColor != Color.Black)
            {
                item.BgColor = Color.Black;
                item.FntColor = Color.White;
            }
            else if (item.BgColor == Color.Black)
            {
                item.BgColor = item.BdColor;
                item.FntColor = Color.Black;
            }

            ColorsObservableCollection.Insert(index, item);
        }

        #endregion
        #region Private Methods

        private async Task BuildListNamesAsync()
        {
            _namesList = await ListNames.BuildNamesList();

            foreach (var l in _namesList)
            {
                ListNamesObservableCollection.Add(l);
            }
        }

        private async Task BuildItemsAsync()
        {
            _itemsList = await Items.BuildItemsList();

            foreach (var i in _itemsList)
            {
                ItemsObservableCollection.Add(i);
            }
        }

        private async Task BuildSectionsAsync()
        {
            _sectionsList = await Sections.BuildSectionsList();

            foreach (var s in _sectionsList)
            {
                SectionsObservableCollection.Add(s);
            }
        }

        private void BuildColorsList()
        {
            if (!testBool)
                IsExpanded = true;

            ColorsObservableCollection?.Clear();

            //Build colors observable collection
            if (ColorsObservableCollection == null || ColorsObservableCollection.Count > 0) return;

            //Build colors observable collection

            _subColors.Clear();

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.DodgerBlue",
                ColorName = "Dodger Blue",
                BgColor = Color.DodgerBlue,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.Tomato",
                ColorName = "Tomato",
                BgColor = Color.Tomato,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.Green",
                ColorName = "Green",
                BgColor = Color.Green,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.Orange",
                ColorName = "Orange",
                BgColor = Color.Orange,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.Brown",
                ColorName = "Brown",
                BgColor = Color.Brown,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.Maroon",
                ColorName = "Maroon",
                BgColor = Color.Maroon,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.DarkSlateGray",
                ColorName = "Dark Slate Gray",
                BgColor = Color.DarkSlateGray,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.DimGray",
                ColorName = "Dim Gray",
                BgColor = Color.DimGray,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.LightGreen",
                ColorName = "Light Green",
                BgColor = Color.LightGreen,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.CornflowerBlue",
                ColorName = "Cornflower Blue",
                BgColor = Color.CornflowerBlue,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.LightSalmon",
                ColorName = "Light Salmon",
                BgColor = Color.LightSalmon,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.Blue",
                ColorName = "Blue",
                BgColor = Color.Blue,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.DarkSlateBlue",
                ColorName = "Dark Slate Blue",
                BgColor = Color.DarkSlateBlue,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.LightSlateGray",
                ColorName = "Light Slate Gray",
                BgColor = Color.LightSlateGray,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.LimeGreen",
                ColorName = "Lime Green",
                BgColor = Color.LimeGreen,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.Yellow",
                ColorName = "Yellow",
                BgColor = Color.Yellow,
                FntColor = Color.Black
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.DodgerBlue",
                ColorName = "Dodger Blue",
                BgColor = Color.DodgerBlue,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.Tomato",
                ColorName = "Tomato",
                BgColor = Color.Tomato,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.Green",
                ColorName = "Green",
                BgColor = Color.Green,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.Orange",
                ColorName = "Orange",
                BgColor = Color.Orange,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.Brown",
                ColorName = "Brown",
                BgColor = Color.Brown,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.Maroon",
                ColorName = "Maroon",
                BgColor = Color.Maroon,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.DarkSlateGray",
                ColorName = "Dark Slate Gray",
                BgColor = Color.DarkSlateGray,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.DimGray",
                ColorName = "Dim Gray",
                BgColor = Color.DimGray,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.LightGreen",
                ColorName = "Light Green",
                BgColor = Color.LightGreen,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.CornflowerBlue",
                ColorName = "Cornflower Blue",
                BgColor = Color.CornflowerBlue,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.LightSalmon",
                ColorName = "Light Salmon",
                BgColor = Color.LightSalmon,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.Blue",
                ColorName = "Blue",
                BgColor = Color.Blue,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.DarkSlateBlue",
                ColorName = "Dark Slate Blue",
                BgColor = Color.DarkSlateBlue,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.LightSlateGray",
                ColorName = "Light Slate Gray",
                BgColor = Color.LightSlateGray,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.LimeGreen",
                ColorName = "Lime Green",
                BgColor = Color.LimeGreen,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.Yellow",
                ColorName = "Yellow",
                BgColor = Color.Yellow,
                FntColor = Color.Black
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.DodgerBlue",
                ColorName = "Dodger Blue",
                BgColor = Color.DodgerBlue,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.Tomato",
                ColorName = "Tomato",
                BgColor = Color.Tomato,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.Green",
                ColorName = "Green",
                BgColor = Color.Green,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.Orange",
                ColorName = "Orange",
                BgColor = Color.Orange,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.Brown",
                ColorName = "Brown",
                BgColor = Color.Brown,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.Maroon",
                ColorName = "Maroon",
                BgColor = Color.Maroon,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.DarkSlateGray",
                ColorName = "Dark Slate Gray",
                BgColor = Color.DarkSlateGray,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.DimGray",
                ColorName = "Dim Gray",
                BgColor = Color.DimGray,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.LightGreen",
                ColorName = "Light Green",
                BgColor = Color.LightGreen,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.CornflowerBlue",
                ColorName = "Cornflower Blue",
                BgColor = Color.CornflowerBlue,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.LightSalmon",
                ColorName = "Light Salmon",
                BgColor = Color.LightSalmon,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.Blue",
                ColorName = "Blue",
                BgColor = Color.Blue,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.DarkSlateBlue",
                ColorName = "Dark Slate Blue",
                BgColor = Color.DarkSlateBlue,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.LightSlateGray",
                ColorName = "Light Slate Gray",
                BgColor = Color.LightSlateGray,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.LimeGreen",
                ColorName = "Lime Green",
                BgColor = Color.LimeGreen,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.Yellow",
                ColorName = "Yellow",
                BgColor = Color.Yellow,
                FntColor = Color.Black
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.DodgerBlue",
                ColorName = "Dodger Blue",
                BgColor = Color.DodgerBlue,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.Tomato",
                ColorName = "Tomato",
                BgColor = Color.Tomato,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.Green",
                ColorName = "Green",
                BgColor = Color.Green,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.Orange",
                ColorName = "Orange",
                BgColor = Color.Orange,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.Brown",
                ColorName = "Brown",
                BgColor = Color.Brown,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.Maroon",
                ColorName = "Maroon",
                BgColor = Color.Maroon,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.DarkSlateGray",
                ColorName = "Dark Slate Gray",
                BgColor = Color.DarkSlateGray,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.DimGray",
                ColorName = "Dim Gray",
                BgColor = Color.DimGray,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.LightGreen",
                ColorName = "Light Green",
                BgColor = Color.LightGreen,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.CornflowerBlue",
                ColorName = "Cornflower Blue",
                BgColor = Color.CornflowerBlue,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.LightSalmon",
                ColorName = "Light Salmon",
                BgColor = Color.LightSalmon,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.Blue",
                ColorName = "Blue",
                BgColor = Color.Blue,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.DarkSlateBlue",
                ColorName = "Dark Slate Blue",
                BgColor = Color.DarkSlateBlue,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.LightSlateGray",
                ColorName = "Light Slate Gray",
                BgColor = Color.LightSlateGray,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.LimeGreen",
                ColorName = "Lime Green",
                BgColor = Color.LimeGreen,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.Yellow",
                ColorName = "Yellow",
                BgColor = Color.Yellow,
                FntColor = Color.Black
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.DodgerBlue",
                ColorName = "Dodger Blue",
                BgColor = Color.DodgerBlue,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.Tomato",
                ColorName = "Tomato",
                BgColor = Color.Tomato,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.Green",
                ColorName = "Green",
                BgColor = Color.Green,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.Orange",
                ColorName = "Orange",
                BgColor = Color.Orange,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.Brown",
                ColorName = "Brown",
                BgColor = Color.Brown,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.Maroon",
                ColorName = "Maroon",
                BgColor = Color.Maroon,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.DarkSlateGray",
                ColorName = "Dark Slate Gray",
                BgColor = Color.DarkSlateGray,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.DimGray",
                ColorName = "Dim Gray",
                BgColor = Color.DimGray,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.LightGreen",
                ColorName = "Light Green",
                BgColor = Color.LightGreen,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.CornflowerBlue",
                ColorName = "Cornflower Blue",
                BgColor = Color.CornflowerBlue,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.LightSalmon",
                ColorName = "Light Salmon",
                BgColor = Color.LightSalmon,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.Blue",
                ColorName = "Blue",
                BgColor = Color.Blue,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.DarkSlateBlue",
                ColorName = "Dark Slate Blue",
                BgColor = Color.DarkSlateBlue,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.LightSlateGray",
                ColorName = "Light Slate Gray",
                BgColor = Color.LightSlateGray,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.LimeGreen",
                ColorName = "Lime Green",
                BgColor = Color.LimeGreen,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.Yellow",
                ColorName = "Yellow",
                BgColor = Color.Yellow,
                FntColor = Color.Black
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.DodgerBlue",
                ColorName = "Dodger Blue",
                BgColor = Color.DodgerBlue,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.Tomato",
                ColorName = "Tomato",
                BgColor = Color.Tomato,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.Green",
                ColorName = "Green",
                BgColor = Color.Green,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.Orange",
                ColorName = "Orange",
                BgColor = Color.Orange,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.Brown",
                ColorName = "Brown",
                BgColor = Color.Brown,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.Maroon",
                ColorName = "Maroon",
                BgColor = Color.Maroon,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.DarkSlateGray",
                ColorName = "Dark Slate Gray",
                BgColor = Color.DarkSlateGray,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.DimGray",
                ColorName = "Dim Gray",
                BgColor = Color.DimGray,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.LightGreen",
                ColorName = "Light Green",
                BgColor = Color.LightGreen,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.CornflowerBlue",
                ColorName = "Cornflower Blue",
                BgColor = Color.CornflowerBlue,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.LightSalmon",
                ColorName = "Light Salmon",
                BgColor = Color.LightSalmon,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.Blue",
                ColorName = "Blue",
                BgColor = Color.Blue,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.DarkSlateBlue",
                ColorName = "Dark Slate Blue",
                BgColor = Color.DarkSlateBlue,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.LightSlateGray",
                ColorName = "Light Slate Gray",
                BgColor = Color.LightSlateGray,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.LimeGreen",
                ColorName = "Lime Green",
                BgColor = Color.LimeGreen,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.Yellow",
                ColorName = "Yellow",
                BgColor = Color.Yellow,
                FntColor = Color.Black
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.DodgerBlue",
                ColorName = "Dodger Blue",
                BgColor = Color.DodgerBlue,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.Tomato",
                ColorName = "Tomato",
                BgColor = Color.Tomato,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.Green",
                ColorName = "Green",
                BgColor = Color.Green,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.Orange",
                ColorName = "Orange",
                BgColor = Color.Orange,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.Brown",
                ColorName = "Brown",
                BgColor = Color.Brown,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.Maroon",
                ColorName = "Maroon",
                BgColor = Color.Maroon,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.DarkSlateGray",
                ColorName = "Dark Slate Gray",
                BgColor = Color.DarkSlateGray,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.DimGray",
                ColorName = "Dim Gray",
                BgColor = Color.DimGray,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.LightGreen",
                ColorName = "Light Green",
                BgColor = Color.LightGreen,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.CornflowerBlue",
                ColorName = "Cornflower Blue",
                BgColor = Color.CornflowerBlue,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.LightSalmon",
                ColorName = "Light Salmon",
                BgColor = Color.LightSalmon,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.Blue",
                ColorName = "Blue",
                BgColor = Color.Blue,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.DarkSlateBlue",
                ColorName = "Dark Slate Blue",
                BgColor = Color.DarkSlateBlue,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.LightSlateGray",
                ColorName = "Light Slate Gray",
                BgColor = Color.LightSlateGray,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.LimeGreen",
                ColorName = "Lime Green",
                BgColor = Color.LimeGreen,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.Yellow",
                ColorName = "Yellow",
                BgColor = Color.Yellow,
                FntColor = Color.Black
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.DodgerBlue",
                ColorName = "Dodger Blue",
                BgColor = Color.DodgerBlue,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.Tomato",
                ColorName = "Tomato",
                BgColor = Color.Tomato,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.Green",
                ColorName = "Green",
                BgColor = Color.Green,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.Orange",
                ColorName = "Orange",
                BgColor = Color.Orange,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.Brown",
                ColorName = "Brown",
                BgColor = Color.Brown,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.Maroon",
                ColorName = "Maroon",
                BgColor = Color.Maroon,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.DarkSlateGray",
                ColorName = "Dark Slate Gray",
                BgColor = Color.DarkSlateGray,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.DimGray",
                ColorName = "Dim Gray",
                BgColor = Color.DimGray,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.LightGreen",
                ColorName = "Light Green",
                BgColor = Color.LightGreen,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.CornflowerBlue",
                ColorName = "Cornflower Blue",
                BgColor = Color.CornflowerBlue,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.LightSalmon",
                ColorName = "Light Salmon",
                BgColor = Color.LightSalmon,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.Blue",
                ColorName = "Blue",
                BgColor = Color.Blue,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.DarkSlateBlue",
                ColorName = "Dark Slate Blue",
                BgColor = Color.DarkSlateBlue,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.LightSlateGray",
                ColorName = "Light Slate Gray",
                BgColor = Color.LightSlateGray,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.LimeGreen",
                ColorName = "Lime Green",
                BgColor = Color.LimeGreen,
                FntColor = Color.White
            });

            _subColors.Add(new Colors
            {
                BackGroundColor = "Color.Yellow",
                ColorName = "Yellow",
                BgColor = Color.Yellow,
                FntColor = Color.Black
            });

            foreach (var subColor in _subColors)
            {
                ColorsObservableCollection?.Add(subColor);
            }
        }
        

        #endregion
    }
}
