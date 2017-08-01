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



        public SubWindow()
        {
            InitializeComponent();
            IsVaccinated = MainWindow.IsVaccinated;
            VaccinatedForFree = MainWindow.VaccinatedForFree;
            VaccinCombo = MainWindow.VaccinCombo;
            IsBreastfead = MainWindow.IsBreastfead;
            listBox.IsEnabled = true;

        }
        private void checkBox1_Checked(object sender, RoutedEventArgs e)
        {
            IsBreastfead = !IsBreastfead;
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
        }

        private void radioButton_Checked(object sender, RoutedEventArgs e)
        {
            VaccinatedForFree = !VaccinatedForFree;
        }
        
        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {
            IsVaccinated = !IsVaccinated;
        }

       
    }
}
