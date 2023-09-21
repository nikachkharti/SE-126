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
        private CountryModel SelectedCountry { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            _unitOfWork = new UnitOfWork();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            RefreshCountryList();
        }


        private async void RefreshCountryList()
        {
            try
            {
                CountryList.Items.Clear();
                var allCountries = await _unitOfWork.Country.GetAllCountries();
                allCountries.ForEach(country => CountryList.Items.Add(country));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "დაფიქსირდა შეცდომა", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private async void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (FormIsValid())
                {
                    CountryModel newCountry = new() { Country = CountryValue.Text };
                    await _unitOfWork.Country.AddCountry(newCountry);
                    MessageBox.Show("ახალი ქვეყანა წარმატებით დაემატა", "წარმატებული ოპერაცია", MessageBoxButton.OK, MessageBoxImage.Information);
                    RefreshCountryList();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("შემოყვანილი ინფორმაცია არასწორია", "დაფიქსირდა შეცდომა", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "დაფიქსირდა შეცდომა", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        private void ClearForm() => CountryValue.Text = string.Empty;
        private bool FormIsValid() => !string.IsNullOrWhiteSpace(CountryValue.Text);
        private CountryModel SelectCountry() => CountryList.SelectedItem as CountryModel;

        private async void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBoxResult response = MessageBox.Show("ინფორმაციის წაშლა", "ნამდვილად გსურთ წაშლა?", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (response == MessageBoxResult.Yes)
                {
                    await _unitOfWork.Country.DeleteCountry(SelectedCountry.CountryId);
                    MessageBox.Show("ქვეყანა წარმატებით წაიშალა ბაზიდან", "წარმატებული ოპერაცია", MessageBoxButton.OK, MessageBoxImage.Information);
                    RefreshCountryList();
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "დაფიქსირდა შეცდომა", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void CountryList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                SelectedCountry = SelectCountry();
                if (SelectedCountry != null)
                    CountryValue.Text = SelectedCountry.Country;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "დაფიქსირდა შეცდომა", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private async void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (FormIsValid())
                {
                    MessageBoxResult response = MessageBox.Show("ინფორმაციის რედაქტირება", "ნამდვილად გსურთ რედაქტირება?", MessageBoxButton.YesNo, MessageBoxImage.Question);

                    if (response == MessageBoxResult.Yes)
                    {
                        SelectedCountry = SelectCountry();
                        SelectedCountry.Country = CountryValue.Text;

                        await _unitOfWork.Country.UpdateCountry(SelectedCountry);
                        MessageBox.Show("ქვეყანა წარმატებით დარედაქტირდა", "წარმატებული ოპერაცია", MessageBoxButton.OK, MessageBoxImage.Information);
                        RefreshCountryList();
                    }
                }
                else
                {
                    MessageBox.Show("შემოყვანილი ინფორმაცია არასწორია", "დაფიქსირდა შეცდომა", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "დაფიქსირდა შეცდომა", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void SearchValue_TextChanged(object sender, TextChangedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
