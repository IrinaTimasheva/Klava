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

namespace Klava
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (ButtonShift.Content.ToString() == "shift" && ButtonCapsLock.Content.ToString() == "capslock")
            {

                textbox1.Text += string.Format("{0}", (sender as Button).Content.ToString().ToLower());
            }
            else
            {

                textbox1.Text += string.Format("{0}", (sender as Button).Content.ToString().ToUpper());
            }
            ButtonShift.Content = "shift";


        }




        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (ButtonShift.Content.ToString() == "SHIFT")
            {
                (sender as Button).Content = (sender as Button).Content.ToString().ToLower();
            }
            else
            {
                (sender as Button).Content = (sender as Button).Content.ToString().ToUpper();
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            textbox1.Text += string.Format("{0}", " ");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (ButtonCapsLock.Content.ToString() == "CAPSLOCK")
            {
                (sender as Button).Content = (sender as Button).Content.ToString().ToLower();
            }
            else
            {
                (sender as Button).Content = (sender as Button).Content.ToString().ToUpper();
            }
        }
    }
}

    

