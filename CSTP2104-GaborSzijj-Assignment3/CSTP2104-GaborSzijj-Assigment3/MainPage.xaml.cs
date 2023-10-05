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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace CSTP2104_GaborSzijj_Assigment3
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void btnBudapest_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Budapest));
        }

        private void btnLisbon_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Lisbon));
        }

        private void btnVienna_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Vienna));
        }

        private void btnParis_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Paris));
        }

        private void btnOttawa_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Ottawa));
        }
    }
}
