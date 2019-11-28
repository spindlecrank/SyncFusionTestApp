using Syncfusion.ListView.XForms;
using SyncFusionTestApp.Models;
using SyncFusionTestApp.ViewModels;
using Xamarin.Essentials;
using Xamarin.Forms;
using SelectionChangedEventArgs = Syncfusion.XForms.ComboBox.SelectionChangedEventArgs;

namespace SyncFusionTestApp.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    public partial class MainPage : ContentPage
    {
        private readonly MainPageViewModel _viewModel;

        private double _width;
        private double _height;

        public MainPage()
        {
            InitializeComponent();

            _viewModel = new MainPageViewModel();

            BindingContext = _viewModel;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            //Build all lists for controls
            await _viewModel.BuildAllListsAsync();
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height); //must be called

            if (_width == width && _height == height) return;

            _width = width;
            _height = height;

            if (width > height)
            {
                if (DeviceInfo.Idiom == DeviceIdiom.Desktop)
                    listView.LayoutManager = gridLayout = new GridLayout() { SpanCount = 4 };
                if (DeviceInfo.Idiom == DeviceIdiom.Tablet)
                    listView.LayoutManager = gridLayout = new GridLayout() { SpanCount = 3 };
                if (DeviceInfo.Idiom == DeviceIdiom.Phone)
                    listView.LayoutManager = gridLayout = new GridLayout() { SpanCount = 4 };
            }
            else if (height > width)
            {
                if (DeviceInfo.Idiom == DeviceIdiom.Desktop)
                    listView.LayoutManager = gridLayout = new GridLayout() { SpanCount = 3 };
                if (DeviceInfo.Idiom == DeviceIdiom.Tablet)
                    listView.LayoutManager = gridLayout = new GridLayout() { SpanCount = 2 };
                if (DeviceInfo.Idiom == DeviceIdiom.Phone)
                    listView.LayoutManager = gridLayout = new GridLayout() { SpanCount = 2 };
            }
        }

        private void ListView_OnItemTapped(object sender, Syncfusion.ListView.XForms.ItemTappedEventArgs e)
        {
            if (!(e.ItemData is Colors item)) return;

            var index = listView.DataSource.DisplayItems.IndexOf(item);

            _viewModel.DoUpdate(item);

            listView.LayoutManager.ScrollToRowIndex(index / gridLayout.SpanCount, Syncfusion.ListView.XForms.ScrollToPosition.Center, true);
        }

        private void ListItemComboBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.Value != null)
                _viewModel.Items = e.Value as Items;

            if (_viewModel.Name == null) ListItemComboBox.SelectedItem = null;
        }

        private void SectionNameComboBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.Value != null)
                _viewModel.Sections = e.Value as Sections;

            if (_viewModel.Section == null) SectionNameComboBox.SelectedItem = null;
        }

        private void ComboBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _viewModel.ListNames = e.Value as ListNames;
        }
    }
}
