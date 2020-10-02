using KassaSysteemUWP.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace KassaSysteemUWP.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ManageEventPage : Page
    {

        private static Evenement EVENT;
        private List<Day> days = new List<Day>();
        private List<Family> families = new List<Family>();

        public ManageEventPage()
        {
            this.InitializeComponent();
            EventNameTextBlock.Text = EVENT.Name;
            days = EVENT.Days;
        }

        private void MenuBttn_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

        }

        public static void SetEVENT(Evenement evenement)
        {
            EVENT = evenement;

        }

        private async void ShowMessage(string warning)
        {
            await new MessageDialog(warning).ShowAsync();
        }

        private void DaySelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            families = ((Day)DayListBox.SelectedItem).Families.ToList<Family>();
            FamilyListBox.Visibility = Windows.UI.Xaml.Visibility.Visible;
        }
    }
}
