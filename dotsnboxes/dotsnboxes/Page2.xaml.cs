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
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        int turn = 3;
        int counter = 0;
        int inplay = 0;
        public Page2(int players)
        {
            InitializeComponent();
            inplay = players;
        }

        private void dot_Click(object sender, MouseButtonEventArgs e)
        {
            Ellipse dot = e.Source as Ellipse;
            dot.Fill = Brushes.Black;
            if (counter == 0)
            {
                text.Text = dot.Name.Trim('_');
                counter += 1;
            }
            else if (counter == 1)
            {
                int lineName = (int.Parse(dot.Name.Trim('_')) + int.Parse(text.Text)) / 2;
                Rectangle line = (Rectangle)FindName("_" + lineName);
                line.Fill = Brushes.Black;
                counter -= 1;
            }
        }
    }
}
