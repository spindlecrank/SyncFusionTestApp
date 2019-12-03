using System.ComponentModel;

namespace SyncFusionTestApp.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
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


        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
