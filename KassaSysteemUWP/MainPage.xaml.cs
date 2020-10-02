using KassaSysteemUWP.Pages;
using KassaSysteemUWP.Classes;
using System.Collections.ObjectModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace KassaSysteemUWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        //List of all events that is stored in the Listbox
        private ObservableCollection<Evenement> _evenements;
        internal ObservableCollection<Evenement> Evenements { get => _evenements; set => _evenements = value; }


        public MainPage()
        {
            this.InitializeComponent();
            this._evenements = Evenement.EventList;
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AddEventPage));
        }

        private void eventListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void loadEventBttn_Click(object sender, RoutedEventArgs e)
        {
            ManageEventPage.SetEVENT((Evenement)eventListBox.SelectedItem);
            Frame.Navigate(typeof(ManageEventPage));
        }
    }
}
