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
        public MainWindow()
        {
            InitializeComponent();
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

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
           name = textBox.Text;
            birthday = textBox1.Text;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if(name!="" && birthday != "")
            {
                Program a = new Program();
                Program.initializeBaby(name,DateTime.Parse( birthday));
            }
        }
    }
}
