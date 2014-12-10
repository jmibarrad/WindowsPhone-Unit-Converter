using System;
using System.Windows;
using System.Windows.Media;
using Microsoft.Phone.Controls;
using Microsoft.Xna.Framework.GamerServices;

namespace UnitConverter
{
    public partial class MainPage : PhoneApplicationPage
    {
        public MainPage()
        {
            InitializeComponent();

        }
        public void SetFrench(object sender, System.Windows.Input.GestureEventArgs e)
        {
            MyGlobals.Total=1;
            MessageBox.Show("Francais le active.");
        }

        public void SetItalian(object sender, System.Windows.Input.GestureEventArgs e)
        {
            MyGlobals.Total = 2;
            MessageBox.Show("Lingua Italiano abilitato.");
        }
        public void SetEnglish(object sender, System.Windows.Input.GestureEventArgs e)
        {
            MyGlobals.Total = 3;
            MessageBox.Show("English mode on");
        }
        public void SetPortugues(object sender, System.Windows.Input.GestureEventArgs e)
        {
            MyGlobals.Total = 4;
            MessageBox.Show("Portoghese abilitato.");
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