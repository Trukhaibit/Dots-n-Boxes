using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace dotsnboxes
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void two_Click(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new Page2(2));
        }

        private void three_Click(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new Page2(3));
        }

        private void four_Click(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new Page2(4));
        }

        private void options_Click(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new Page3(0,0,0,0,2));
        }
    }
}
