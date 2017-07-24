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
        
        static Program a;
        public MainWindow()
        {
            InitializeComponent();
            a = new Program();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "Enter Baby's name: ";
            textBox1.Text = "Enter Baby's birthday(year.month.day): ";
            
           //
        }
        
        private void button2_Click(object sender, RoutedEventArgs e)
        {
           name = textBox.Text;
          birthday = textBox1.Text;
            if (name!="" && birthday != "")
            {
                
                a.initializeBaby(name,DateTime.Parse( birthday));
                displayBox.Text = a.getBabysAge();
            }
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            

        }
    }
}
