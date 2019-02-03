using System.Windows;
using System.Windows.Input;
using ATTMetroDemo.Facade;

namespace ATTMetroDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            redSlider.Label = "Red";
            blueSlider.Label = "Blue";
            greenSlider.Label = "Green";
            txtRedLabel.Text = redSlider.Label;
            txtGreenLabel.Text = greenSlider.Label;
            txtBlueLabel.Text = blueSlider.Label;
            ////aboutWindow.Show();
        }

        private void btnStartLeftClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Start Clicked");
        }

        private async void  evtJobTimeChangeKeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key != Key.Enter) return;
            tbJobTime.IsEnabled = false;
            tbJobTimeReport.Text = AMDFacade.UpdateJobTime(tbJobTime.Text); 
            tbJobTime.IsEnabled = true;
        }

        private void evtAbortClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}