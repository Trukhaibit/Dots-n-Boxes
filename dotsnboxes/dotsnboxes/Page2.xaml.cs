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
        int turn = 1;
        int counter = 0;
        int inplay = 0;
        Brush color = Brushes.Red;
        public Page2(int players)
        {
            InitializeComponent();
            inplay = players;
        }

        public void turn_Change()
        {
            if (turn == 1)
            {
                color = Brushes.Red;
                turn += 1;
            }
            else if (turn == 2)
            {
                color = Brushes.Blue;
                turn += 1;
            }
            else if (turn == 3)
            {
                color = Brushes.Yellow;
                turn += 1;
            }
            else
            {
                color = Brushes.Green;
                turn = 1;
            }
            
        }

        private void line_Click(object sender, MouseButtonEventArgs e)
        {
            turn_Change();
            Rectangle line = e.Source as Rectangle;
            line.Fill = color;
            check_Boxes();
        }

        public void check_Boxes()
        {
            int[] boxes = { 22, 24, 26 };

            foreach(int b in boxes)
            {
                Rectangle top = (Rectangle)FindName("_" + (b - 21));
                Rectangle left = (Rectangle)FindName("_" + (b - 1));
                Rectangle right = (Rectangle)FindName("_" + (b + 1));
                Rectangle bottom = (Rectangle)FindName("_" + (b + 21));
                Rectangle box = (Rectangle)FindName("_" + (b));

                if (top.Fill != Brushes.White && left.Fill != Brushes.White && right.Fill != Brushes.White && bottom.Fill != Brushes.White && box.Fill == Brushes.White)
                {
                    box.Fill = color;
                    turn -= 1;
                }
            }
        }
    }
}
