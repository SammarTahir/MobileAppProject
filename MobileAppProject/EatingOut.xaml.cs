using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace MobileAppProject
{
    public sealed partial class EatingOut : Page
    {
        public EatingOut()
        {
            this.InitializeComponent();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage), null);
        }

        private void Fish(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(fish), null);
        }

        private void RichFish(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(RichFish), null);
        }

        private void White(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(WhiteMeat), null);
        }

        private void Red(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(RedMeat), null);
        }

        private void Smoked(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SmokedMeat), null);
        }

        private void Green(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(GreenVeggies), null);
        }

        private void Roasted(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(RoastedVeggies), null);
        }
    }
}
