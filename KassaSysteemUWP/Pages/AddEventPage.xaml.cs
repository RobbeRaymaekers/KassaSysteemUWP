﻿using KassaSysteemUWP.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace KassaSysteemUWP.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AddEventPage : Page
    {
        public AddEventPage()
        {
            this.InitializeComponent();
        }

        private void AddEvenementButton_Click(object sender, RoutedEventArgs e)
        {
            int n;
            if (!int.TryParse(daysEventBox.Text, out n))
            {
                showMessage("Aantal dagen moet een geheel getal zijn!", "U hebt waarschijnlijk een fout gemaakt");
            }
            else
            {
                try
                {
                    Evenement newEvent = new Evenement(nameEventBox.Text, n);
                    Frame.Navigate(typeof(MainPage));
                    showMessage("Het nieuwe evenement " + nameEventBox.Text + " is aangemaakt!");
                }
                catch (ArgumentException ae)
                {
                    showMessage("Een evenement met deze naam bestaat al", "U hebt waarschijnlijk een fout gemaakt");
                }
                
            }
           
        }

        private void CancelEvenementButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private async void showMessage(String warning, String Title)
        {
            await new MessageDialog(warning, Title).ShowAsync();
        }

        private async void showMessage(String warning)
        {
            await new MessageDialog(warning).ShowAsync();
        }


    }
}
