using System.Windows;
using System.Windows.Controls;

namespace Assignment_10_1_Final_Group_Project
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ReserveButton_Click(object sender, RoutedEventArgs e)
        {
            // Code to handle reservation logic
            string customerName = CustomerName.Text;
            string reservationDate = ReservationDate.SelectedDate.ToString();
            string reservationTime = (ReservationTime.SelectedItem as ComboBoxItem)?.Content.ToString();

            // Placeholder: Save reservation to database (not implemented in this example)
            MessageBox.Show($"Reservation made for {customerName} on {reservationDate} at {reservationTime}.");
        }

        private void SavePreferencesButton_Click(object sender, RoutedEventArgs e)
        {
            // Code to handle saving customer preferences
            string customerName = PreferenceCustomerName.Text;
            string preferences = Preferences.Text;

            // Placeholder: Save preferences to database (not implemented in this example)
            MessageBox.Show($"Preferences saved for {customerName}.");
        }

        private void BookEventButton_Click(object sender, RoutedEventArgs e)
        {
            // Code to handle special event booking
            string customerName = EventCustomerName.Text;
            string eventDate = EventDate.SelectedDate.ToString();
            string eventDetails = EventDetails.Text;

            // Placeholder: Save event details to database (not implemented in this example)
            MessageBox.Show($"Event booked for {customerName} on {eventDate}. Details: {eventDetails}");
        }
    }
}
