using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using SyncFusionTestApp.Models;
using Xamarin.Forms;

namespace SyncFusionTestApp.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
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


        private bool _isExpanded;

        public bool IsExpanded
        {
            get => _isExpanded;
            set
            {
                _isExpanded = value;
                OnPropertyChanged("IsExpanded");
            }
        }

        private ListNames _listNames;

        public ListNames ListNames
        {
            get => _listNames;
            set
            {
                _listNames = value; 
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
                OnPropertyChanged("Sections");
            }
        }


        private readonly List<Colors> _subColors = new List<Colors>();
        private List<ListNames> _namesList = new List<ListNames>();
        private List<Items> _itemsList = new List<Items>();
        private List<Sections> _sectionsList = new List<Sections>();

        public ObservableCollection<Colors> ColorsObservableCollection { get; set; }
        public ObservableCollection<ListNames> ListNamesObservableCollection { get; set; }
        public ObservableCollection<Items> ItemsObservableCollection { get; set; }
        public ObservableCollection<Sections> SectionsObservableCollection { get; set; }

        #endregion

        #region CTOR

        public MainPageViewModel()
        {
            ColorsObservableCollection = new ObservableCollection<Colors>();
            ListNamesObservableCollection = new ObservableCollection<ListNames>();
            ItemsObservableCollection = new ObservableCollection<Items>();
            SectionsObservableCollection = new ObservableCollection<Sections>();
        }

        #endregion

        public async Task BuildAllListsAsync()
        {
            await BuildListNames();
            await BuildItems();
            BuildColorsList();
        }

        public void DoUpdate(Colors item)
        {
            int index = ColorsObservableCollection.IndexOf(item);

            ColorsObservableCollection.Remove(item);

            item.BgColor = Color.Black;

            ColorsObservableCollection.Insert(index, item);
        }

        private async Task BuildListNames()
        {
            _namesList = await ListNames.BuildNamesList();

            foreach (var l in _namesList)
            {
                ListNamesObservableCollection.Add(l);
            }
        }

        private async Task BuildItems()
        {
            _itemsList = await Items.BuildItemsList();

            foreach (var i in _itemsList)
            {
                ItemsObservableCollection.Add(i);
            }
        }

        private async Task BuildSections()
        {
            _sectionsList = await Sections.BuildSectionsList();

            foreach (var s in _sectionsList)
            {
                SectionsObservableCollection.Add(s);
            }
        }

        public void BuildColorsList()
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

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
