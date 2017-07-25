﻿using System;
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
                
                a.initializeBaby(name,DateTime.Parse( birthday));
                displayBox.Text = a.getBabysAge();
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
           // displayBox.Text = "";
        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            displayBox.Text = a.getFeedingPlan();
        }

        private void ListBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            displayBox.Text = a.getVaccinationPlan();
        }

        private void ListBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {
            displayBox.Text = a.getBabysAge();
        }

        private void ListBoxItem_Selected_3(object sender, RoutedEventArgs e)
        {
            displayBox.Text = a.getNearestDoctorsAppointment();
        }

        private void ListBoxItem_Selected_4(object sender, RoutedEventArgs e)
        {
            displayBox.Text = a.getBabysSkills();
        }
    }
}