using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using radio.Resources;
using Microsoft.Devices.Radio;
using Microsoft.Phone.Tasks;

namespace radio
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            MessageBox.Show("Plugin Your Headphones to continue(Headphones work as an Antenna)");

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            
            // Create an instance of the FMRadio class.
            FMRadio myRadio = FMRadio.Instance;
            // Turn the radio on.
            myRadio.PowerMode = RadioPowerMode.Off;
            myRadio.PowerMode = RadioPowerMode.On;
            // Set the region. 
            myRadio.CurrentRegion = RadioRegion.Europe;
            // Set the frequency.
            myRadio.Frequency = 96.3;
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            // Create an instance of the FMRadio class.
            FMRadio myRadio = FMRadio.Instance;
            // Turn the radio on.
            myRadio.PowerMode = RadioPowerMode.Off;
            myRadio.PowerMode = RadioPowerMode.On;
            // Set the region. 
            myRadio.CurrentRegion = RadioRegion.Europe;
            // Set the frequency.
            myRadio.Frequency = 106.5;

        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            // Create an instance of the FMRadio class.
            FMRadio myRadio = FMRadio.Instance;
            // Turn the radio on.
            myRadio.PowerMode = RadioPowerMode.Off;
            myRadio.PowerMode = RadioPowerMode.On;
            // Set the region. 
            myRadio.CurrentRegion = RadioRegion.Europe;
            // Set the frequency.
            myRadio.Frequency = 93.5;
        }

        private void RadioButton_Checked_3(object sender, RoutedEventArgs e)
        {
            // Create an instance of the FMRadio class.
            FMRadio myRadio = FMRadio.Instance;
            // Turn the radio on.
            myRadio.PowerMode = RadioPowerMode.Off;
            myRadio.PowerMode = RadioPowerMode.On;
            // Set the region. 
            myRadio.CurrentRegion = RadioRegion.Europe;
            // Set the frequency.
            myRadio.Frequency = 91.1;
        }

        private void RadioButton_Checked_4(object sender, RoutedEventArgs e)
        {
            // Create an instance of the FMRadio class.
            FMRadio myRadio = FMRadio.Instance;
            // Turn the radio on.
            myRadio.PowerMode = RadioPowerMode.Off;
            myRadio.PowerMode = RadioPowerMode.On;
            // Set the region. 
            myRadio.CurrentRegion = RadioRegion.Europe;
            // Set the frequency.
            myRadio.Frequency = 95.0;
        }

        private void RadioButton_Checked_5(object sender, RoutedEventArgs e)
        {
            // Create an instance of the FMRadio class.
            FMRadio myRadio = FMRadio.Instance;
            // Turn the radio on.
            myRadio.PowerMode = RadioPowerMode.Off;
            myRadio.PowerMode = RadioPowerMode.On;
            // Set the region. 
            myRadio.CurrentRegion = RadioRegion.Europe;
            // Set the frequency.
            myRadio.Frequency = 92.2;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FMRadio myRadio = FMRadio.Instance;
            // Turn the radio on.
            myRadio.PowerMode = RadioPowerMode.Off;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            PhoneCallTask phoneCallTask = new PhoneCallTask();

            phoneCallTask.PhoneNumber = "0767482482";
            phoneCallTask.DisplayName = "DpM Network";

            phoneCallTask.Show();
        }

        private void TextBlock_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            // Create an instance of the FMRadio class.
            FMRadio myRadio = FMRadio.Instance;
            // Turn the radio on.
            myRadio.PowerMode = RadioPowerMode.Off;
            myRadio.PowerMode = RadioPowerMode.On;
            // Set the region. 
            myRadio.CurrentRegion = RadioRegion.Europe;
            // Set the frequency.
            myRadio.Frequency = 96.3;
        }

        private void TextBlock_Tap_1(object sender, System.Windows.Input.GestureEventArgs e)
        {
            // Create an instance of the FMRadio class.
            FMRadio myRadio = FMRadio.Instance;
            // Turn the radio on.
            myRadio.PowerMode = RadioPowerMode.Off;
            myRadio.PowerMode = RadioPowerMode.On;
            // Set the region. 
            myRadio.CurrentRegion = RadioRegion.Europe;
            // Set the frequency.
            myRadio.Frequency = 106.5;
        }

        private void TextBlock_Tap_2(object sender, System.Windows.Input.GestureEventArgs e)
        {
            // Create an instance of the FMRadio class.
            FMRadio myRadio = FMRadio.Instance;
            // Turn the radio on.
            myRadio.PowerMode = RadioPowerMode.Off;
            myRadio.PowerMode = RadioPowerMode.On;
            // Set the region. 
            myRadio.CurrentRegion = RadioRegion.Europe;
            // Set the frequency.
            myRadio.Frequency = 93.5;
        }

        private void TextBlock_Tap_3(object sender, System.Windows.Input.GestureEventArgs e)
        {
            // Create an instance of the FMRadio class.
            FMRadio myRadio = FMRadio.Instance;
            // Turn the radio on.
            myRadio.PowerMode = RadioPowerMode.Off;
            myRadio.PowerMode = RadioPowerMode.On;
            // Set the region. 
            myRadio.CurrentRegion = RadioRegion.Europe;
            // Set the frequency.
            myRadio.Frequency = 91.1;
        }

        private void TextBlock_Tap_4(object sender, System.Windows.Input.GestureEventArgs e)
        {
            // Create an instance of the FMRadio class.
            FMRadio myRadio = FMRadio.Instance;
            // Turn the radio on.
            myRadio.PowerMode = RadioPowerMode.Off;
            myRadio.PowerMode = RadioPowerMode.On;
            // Set the region. 
            myRadio.CurrentRegion = RadioRegion.Europe;
            // Set the frequency.
            myRadio.Frequency = 95.0;
        }

        private void TextBlock_Tap_5(object sender, System.Windows.Input.GestureEventArgs e)
        {
            // Create an instance of the FMRadio class.
            FMRadio myRadio = FMRadio.Instance;
            // Turn the radio on.
            myRadio.PowerMode = RadioPowerMode.Off;
            myRadio.PowerMode = RadioPowerMode.On;
            // Set the region. 
            myRadio.CurrentRegion = RadioRegion.Europe;
            // Set the frequency.
            myRadio.Frequency = 92.2;
        }

        private void TextBlock_Tap_6(object sender, System.Windows.Input.GestureEventArgs e)
        {
            // Create an instance of the FMRadio class.
            FMRadio myRadio = FMRadio.Instance;
            // Turn the radio on.
            myRadio.PowerMode = RadioPowerMode.Off;
            myRadio.PowerMode = RadioPowerMode.On;
            // Set the region. 
            myRadio.CurrentRegion = RadioRegion.Europe;
            // Set the frequency.
            myRadio.Frequency = 94.0;
        }

        private void TextBlock_Tap_7(object sender, System.Windows.Input.GestureEventArgs e)
        {
            // Create an instance of the FMRadio class.
            FMRadio myRadio = FMRadio.Instance;
            // Turn the radio on.
            myRadio.PowerMode = RadioPowerMode.Off;
            myRadio.PowerMode = RadioPowerMode.On;
            // Set the region. 
            myRadio.CurrentRegion = RadioRegion.Europe;
            // Set the frequency.
            myRadio.Frequency = 89.6;
        }

        private void TextBlock_Tap_8(object sender, System.Windows.Input.GestureEventArgs e)
        {
            // Create an instance of the FMRadio class.
            FMRadio myRadio = FMRadio.Instance;
            // Turn the radio on.
            myRadio.PowerMode = RadioPowerMode.Off;
            myRadio.PowerMode = RadioPowerMode.On;
            // Set the region. 
            myRadio.CurrentRegion = RadioRegion.Europe;
            // Set the frequency.
            myRadio.Frequency = 100.5;
        }

        private void TextBlock_Tap_9(object sender, System.Windows.Input.GestureEventArgs e)
        {
            // Create an instance of the FMRadio class.
            FMRadio myRadio = FMRadio.Instance;
            // Turn the radio on.
            myRadio.PowerMode = RadioPowerMode.Off;
            myRadio.PowerMode = RadioPowerMode.On;
            // Set the region. 
            myRadio.CurrentRegion = RadioRegion.Europe;
            // Set the frequency.
            myRadio.Frequency = 95.6;
        }

        private void TextBlock_Tap_10(object sender, System.Windows.Input.GestureEventArgs e)
        {
            // Create an instance of the FMRadio class.
            FMRadio myRadio = FMRadio.Instance;
            // Turn the radio on.
            myRadio.PowerMode = RadioPowerMode.Off;
            myRadio.PowerMode = RadioPowerMode.On;
            // Set the region. 
            myRadio.CurrentRegion = RadioRegion.Europe;
            // Set the frequency.
            myRadio.Frequency = 100.0;
        }

        private void TextBlock_Tap_11(object sender, System.Windows.Input.GestureEventArgs e)
        {
            // Create an instance of the FMRadio class.
            FMRadio myRadio = FMRadio.Instance;
            // Turn the radio on.
            myRadio.PowerMode = RadioPowerMode.Off;
            myRadio.PowerMode = RadioPowerMode.On;
            // Set the region. 
            myRadio.CurrentRegion = RadioRegion.Europe;
            // Set the frequency.
            myRadio.Frequency = 88.6;
        }

        private void TextBlock_Tap_12(object sender, System.Windows.Input.GestureEventArgs e)
        {
            // Create an instance of the FMRadio class.
            FMRadio myRadio = FMRadio.Instance;
            // Turn the radio on.
            myRadio.PowerMode = RadioPowerMode.Off;
            myRadio.PowerMode = RadioPowerMode.On;
            // Set the region. 
            myRadio.CurrentRegion = RadioRegion.Europe;
            // Set the frequency.
            myRadio.Frequency = 98.2;
        }

        private void TextBlock_Tap_13(object sender, System.Windows.Input.GestureEventArgs e)
        {
            // Create an instance of the FMRadio class.
            FMRadio myRadio = FMRadio.Instance;
            // Turn the radio on.
            myRadio.PowerMode = RadioPowerMode.Off;
            myRadio.PowerMode = RadioPowerMode.On;
            // Set the region. 
            myRadio.CurrentRegion = RadioRegion.Europe;
            // Set the frequency.
            myRadio.Frequency = 92.7;
        }

     

        
        

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}