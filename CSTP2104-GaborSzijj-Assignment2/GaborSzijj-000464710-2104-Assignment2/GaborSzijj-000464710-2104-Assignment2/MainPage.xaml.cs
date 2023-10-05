using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace GaborSzijj_000464710_2104_Assignment2
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void countryComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (radioCountry.IsChecked == true)
            {
                ComboBoxItem selectedCountryItem = countryComboBox.SelectedItem as ComboBoxItem;

                if (selectedCountryItem != null)
                {
                    string countrySelected = selectedCountryItem.Content as string;

                    if (countrySelected != null)
                    {
                        switch (countrySelected)
                        {
                            case "Canada":
                                txtCapitalOutput.Text = "Ottawa";
                                break;
                            case "Hungary":
                                txtCapitalOutput.Text = "Budapest";
                                break;
                            case "Iran":
                                txtCapitalOutput.Text = "Tehran";
                                break;
                            case "France":
                                txtCapitalOutput.Text = "Paris";
                                break;
                            case "Spain":
                                txtCapitalOutput.Text = "Madrid";
                                break;
                        }
                    }
                }
            }
        }

        private void acronymComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (radioAcronym.IsChecked == true)
            {
                ComboBoxItem selectedAcronymItem = acronymComboBox.SelectedItem as ComboBoxItem;

                if (selectedAcronymItem != null)
                {
                    string acronymSelected = selectedAcronymItem.Content as string;

                    if (acronymSelected != null)
                    {
                        switch (acronymSelected)
                        {
                            case "CPU":
                                txtAcronymOutput.Text = "Central processing unit";
                                break;
                            case "GPU":
                                txtAcronymOutput.Text = "Graphics processing unit";
                                break;
                            case "HDD":
                                txtAcronymOutput.Text = "Hard disk drive";
                                break;
                            case "SSD":
                                txtAcronymOutput.Text = "Solid state drive";
                                break;
                            case "RAM":
                                txtAcronymOutput.Text = "Random access memory";
                                break;
                        }
                    }
                }
            }
        }

        private void radioCountry_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void radioAcronym_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void txtCapitalOutput_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void txtAcronymOutput_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
