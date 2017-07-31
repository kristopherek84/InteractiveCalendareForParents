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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string name="";
        string birthday = "";
        string option = "";
        
        bool isVaccinated=false,vaccinatedForFree=false, vaccinCombo=false, isBreastfead=false;


        static Program a;
        public MainWindow()
        {
            InitializeComponent();
            a = new Program();
            listBox.IsEnabled=false;
            textBox.IsEnabled = false;
            datePicker.IsEnabled = false;

        }
    
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            label.Content = "Enter Baby's name: ";
            label1.Content = "Enter Baby's birthday\n(year.month.day): ";
            datePicker.IsEnabled = true;
            textBox.IsEnabled = true;
            //
        }
        
        private void button2_Click(object sender, RoutedEventArgs e)
        {
           name = textBox.Text;
          birthday = datePicker.Text;
            if (name!="" && birthday != "")
            {
                
                a.InitializeBaby(name,DateTime.Parse( birthday));
                displayBox.Text = a.GetBabysAge();
                listBox.IsEnabled = true;
                label.Content = "";
                label1.Content = "";
            }
           
            
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            displayBox.Text = option;
        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            displayBox.Text = "";
            option = a.GetFeedingPlan(isBreastfead);
        }

        private void ListBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            displayBox.Text = "";
            //checkBox.IsEnabled = true;
            option= a.GetVaccinationPlan(isVaccinated, vaccinatedForFree, vaccinCombo);
        }

        private void ListBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {
            displayBox.Text = "";
            option = a.GetBabysAge();
        }

        private void ListBoxItem_Selected_3(object sender, RoutedEventArgs e)
        {
            displayBox.Text = "";
            option = a.GetNearestDoctorsAppointment();
        }

        private void ListBoxItem_Selected_4(object sender, RoutedEventArgs e)
        {
            displayBox.Text = "";
            option = a.GetBabysSkills();
        }

        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {
            isVaccinated = !isVaccinated;
        }

        private void checkBox1_Checked(object sender, RoutedEventArgs e)
        {
            isBreastfead = !isBreastfead;
        }

        private void radioButton_Checked(object sender, RoutedEventArgs e)
        {
            vaccinatedForFree = !vaccinatedForFree;
        }

        private void radioButton1_Checked(object sender, RoutedEventArgs e)
        {
            vaccinCombo = !vaccinCombo;
        }
    }
}
