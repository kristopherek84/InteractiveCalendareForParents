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
        
        private string _option = "";
        public bool IsVaccinated { get; set; }
        public bool VaccinatedForFree { get; set; }
        public bool VaccinCombo { get; set; }
        public bool IsBreastfead { get; set; }
        public static Program A;


        public SubWindow()
        {
            InitializeComponent();
            A = MainWindow.A;
            IsVaccinated = MainWindow.IsVaccinated;
            if (IsVaccinated)
            {
                checkBox_Copy.IsChecked = true;
                IsVaccinated = true;
            }
            VaccinatedForFree = MainWindow.VaccinatedForFree;
            if (VaccinatedForFree)
            {
                radioButton.IsChecked = true;
                VaccinatedForFree = true;
            }
            VaccinCombo = MainWindow.VaccinCombo;
            if (VaccinCombo)
            {
                radioButton1.IsChecked = true;
                VaccinCombo = true;
            }
            IsBreastfead = MainWindow.IsBreastfead;
            if (IsBreastfead)
            {
                checkBox1.IsChecked = true;
                IsBreastfead = true;
            }
            listBox.IsEnabled = true;

        }
        private void checkBox1_Checked(object sender, RoutedEventArgs e)
        {
            
            
                IsBreastfead = !IsBreastfead;
            MainWindow.IsBreastfead = IsBreastfead;
        }

        private void ListBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {
            displayBox.Text = "";
            _option = MainWindow.A.GetBabysAge();
        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            displayBox.Text = "";
            _option = MainWindow.A.GetFeedingPlan(IsBreastfead);
        }

        private void ListBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            displayBox.Text = "";
           _option = MainWindow.A.GetVaccinationPlan(IsVaccinated, VaccinatedForFree, VaccinCombo);
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
           
                VaccinCombo = !VaccinCombo;
            
            MainWindow.VaccinCombo = VaccinCombo;
        }

        private void radioButton_Checked(object sender, RoutedEventArgs e)
        {
           
          
                VaccinatedForFree = !VaccinatedForFree;
            
            MainWindow.VaccinatedForFree = VaccinatedForFree;
        }
        
        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {
           
            
                IsVaccinated = !IsVaccinated;
           
            MainWindow.IsVaccinated = IsVaccinated;
        }

       
    }
}
