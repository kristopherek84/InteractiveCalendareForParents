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
using System.Windows.Navigation;
using System.Windows.Shapes;
using interactiveCalendareForParents;

namespace InteractiveCalendar
{
    /// <summary>
    /// Interaction logic for SubWindow.xaml
    /// </summary>
    public partial class SubWindow : Window
    {
        
        string _option = "";

        bool _isVaccinated = false, _vaccinatedForFree = false, _vaccinCombo = false, _isBreastfead = false;


        public SubWindow()
        {
            InitializeComponent();
            
            listBox.IsEnabled = true;

        }
        private void checkBox1_Checked(object sender, RoutedEventArgs e)
        {
            _isBreastfead = !_isBreastfead;
        }

        private void ListBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {
            displayBox.Text = "";
            _option = MainWindow.A.GetBabysAge();
        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            displayBox.Text = "";
            _option = MainWindow.A.GetFeedingPlan(_isBreastfead);
        }

        private void ListBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            displayBox.Text = "";
           _option = MainWindow.A.GetVaccinationPlan(_isVaccinated, _vaccinatedForFree, _vaccinCombo);
        }

        private void ListBoxItem_Selected_3(object sender, RoutedEventArgs e)
        {
            displayBox.Text = "";
            _option = MainWindow.A.GetNearestDoctorsAppointment();
        }

        private void ListBoxItem_Selected_4(object sender, RoutedEventArgs e)
        {
            displayBox.Text = "";
            _option = MainWindow.A.GetBabysSkills();
        }
        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            displayBox.Text = _option;
        }
        private void radioButton1_Checked(object sender, RoutedEventArgs e)
        {
            _vaccinCombo = !_vaccinCombo;
        }

        private void radioButton_Checked(object sender, RoutedEventArgs e)
        {
            _vaccinatedForFree = !_vaccinatedForFree;
        }

     

        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {
            _isVaccinated = !_isVaccinated;
        }
    }
}
