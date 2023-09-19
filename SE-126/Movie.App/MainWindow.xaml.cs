using Movie.Models;
using Movie.Service;
using Movie.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Movie.App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IUnitOfWork _unitOfWork;
        private CountryModel countryToDelete;

        public MainWindow()
        {
            InitializeComponent();
            _unitOfWork = new UnitOfWork();
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                var allCountries = await _unitOfWork.Country.GetAllCountries();
                allCountries.ForEach(country => CountryList.Items.Add(country));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CountryList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                countryToDelete = CountryList.SelectedItem as CountryModel;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                await _unitOfWork.Country.DeleteCountry(countryToDelete.CountryId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
