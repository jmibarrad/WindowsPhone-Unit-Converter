using System;
using Microsoft.Phone.Controls;

namespace UnitConverter
{
    public partial class MainPage : PhoneApplicationPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public void Language(object sender, System.Windows.Input.GestureEventArgs e)
        {
        }

        private void About_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/AboutPage.xaml", UriKind.Relative));
        }

        private void Weight_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ConvertPage.xaml?Category=重量", UriKind.Relative));
        }

        private void Length_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ConvertPage.xaml?Category=长度", UriKind.Relative));
        }

        private void Area_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ConvertPage.xaml?Category=面积", UriKind.Relative));
        }

        private void Volume_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ConvertPage.xaml?Category=体积", UriKind.Relative));
        }

        private void Energy_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ConvertPage.xaml?Category=能量", UriKind.Relative));
        }

        private void Angle_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ConvertPage.xaml?Category=角度", UriKind.Relative));
        }

        private void Power_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ConvertPage.xaml?Category=功率", UriKind.Relative));
        }

        private void Pressure_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ConvertPage.xaml?Category=压力", UriKind.Relative));
        }

        private void Temperature_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ConvertPage.xaml?Category=温度", UriKind.Relative));
        }

        private void Velocity_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ConvertPage.xaml?Category=速度", UriKind.Relative));
        }

    }
}