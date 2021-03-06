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
        int inplay = 0;
        int rScore = 0;
        int bScore = 0;
        int gScore = 0;
        int lScore = 0;
        Brush color = Brushes.Crimson;
        public Page2(int players)
        {
            InitializeComponent();
            inplay = players;
            text.Text = inplay.ToString();
            box_Place();
        }

        public void box_Place()
        {
            if (inplay == 2)
            {
                redScore.RenderTransform = new TranslateTransform(60, 0);
                blueScore.RenderTransform = new TranslateTransform(185, 0);
                goldScore.RenderTransform = new TranslateTransform(500, 0);
                limeScore.RenderTransform = new TranslateTransform(500, 0);
            }
            else if (inplay == 3)
            {
                blueScore.RenderTransform = new TranslateTransform(60, 0);
                goldScore.RenderTransform = new TranslateTransform(120, 0);
                limeScore.RenderTransform = new TranslateTransform(500, 0);
            }
        }

        public void turn_Change()
        {
            if (turn == 1)
            {
                color = Brushes.Crimson;
                turn += 1;
            }
            else if (turn == 2)
            {
                color = Brushes.CornflowerBlue;
                turn += 1;
            }
            else if (turn == 3)
            {
                color = Brushes.Gold;
                turn += 1;
            }
            else
            {
                color = Brushes.LimeGreen;
                turn = 1;
            }
            if (inplay == turn - 1)
            {
                turn = 1;
            }

        }

        private void line_Click(object sender, MouseButtonEventArgs e)
        {
            turn_Change();
            Rectangle line = e.Source as Rectangle;
            line.Fill = color;
            check_Boxes();
            if(rScore + bScore + gScore + lScore == 40)
            {
                this.NavigationService.Navigate(new Page3(rScore, bScore, gScore, lScore, inplay));
            }
        }

        public void check_Boxes()
        {
            int[] boxes = {22,24,26,28,30,32,34,36,38,40,64,66,68,70,72,74,76,78,80,82,106,108,110,112,114,116,118,120,122,124,148,150,152,154,156,158,160,162,164,166};
            int turnMem = turn - 1;
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
                    turn = turnMem;
                    if (turn == 0)
                    {
                        turn = inplay;
                    }
                    if (turn == 1)
                    {
                        rScore += 1;
                        redScore.Text = rScore.ToString("00");
                    }
                    else if (turn == 2)
                    {
                        bScore += 1;
                        blueScore.Text = bScore.ToString("00");
                    }
                    else if (turn == 3)
                    {
                        gScore += 1;
                        goldScore.Text = gScore.ToString("00");
                    }
                    else if (turn == 4)
                    {
                        lScore += 1;
                        limeScore.Text = lScore.ToString("00");
                    }
                }
            }
        }
    }
}
