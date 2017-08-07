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
        string _name="";
        string _birthday = "";

        public static bool IsVaccinated { get; set; }
        public static bool VaccinatedForFree { get; set; }
        public static bool VaccinCombo { get; set; }
        public static bool IsBreastfead { get; set; }


        public static Program A;
        public MainWindow()
        {
            InitializeComponent();
            IsVaccinated = false;
            VaccinatedForFree = false;
            VaccinCombo = false;
            IsBreastfead = false;
          
            A = new Program();
           
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
           _name = textBox.Text;
          _birthday = datePicker.Text;
            if (_name!="" && _birthday != "")
            {
               A.InitializeBaby(_name,DateTime.Parse( _birthday));
                SubWindow subWindow = new SubWindow();
                subWindow.Show();
                
            }
           
        }
        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {
            IsVaccinated = !IsVaccinated;
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void checkBox1_Checked(object sender, RoutedEventArgs e)
        {
            IsBreastfead = !IsBreastfead;
        }

        private void radioButton_Checked(object sender, RoutedEventArgs e)
        {
            VaccinatedForFree = !VaccinatedForFree;
        }

        private void radioButton1_Checked(object sender, RoutedEventArgs e)
        {
            VaccinCombo = !VaccinCombo;
        }
    }
}
