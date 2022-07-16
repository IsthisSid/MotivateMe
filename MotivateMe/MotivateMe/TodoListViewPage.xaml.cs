using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MotivateMe
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TodoListViewPage : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }

        public TodoListViewPage()
        {
            InitializeComponent();

            Items = new ObservableCollection<string>
            {
                "Create a to-do list",
                "Grab a book and read it",
                "Find a healthy-ish recipe and cook it",
                "Organize closet",
                "Do something for someone"
            };

            MyListView.ItemsSource = Items;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}

