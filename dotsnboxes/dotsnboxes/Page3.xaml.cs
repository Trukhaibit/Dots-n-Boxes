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
    /// Interaction logic for Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3(int rscore, int bscore, int gscore, int lscore, int inplay)
        {
            InitializeComponent();
            redScore.Text = rscore.ToString();
            blueScore.Text = bscore.ToString();
            goldScore.Text = gscore.ToString();
            limeScore.Text = lscore.ToString();
            if (rscore > bscore && rscore > gscore && rscore > lscore)
            {
                redScore.Height = 130;
                redScore.Width = 132;
                chickenDinner.Text = "Red Wins!";
                chickenDinner.Foreground = Brushes.Crimson;
            }
            else if (bscore > rscore && bscore > gscore && bscore > lscore)
            {
                blueScore.Height = 130;
                blueScore.Width = 132;
                chickenDinner.Text = "Blue Wins!";
                chickenDinner.Foreground = Brushes.Crimson;
            }
            else if (gscore > bscore && gscore > rscore && gscore > lscore)
            {
                goldScore.Height = 130;
                goldScore.Width = 132;
                chickenDinner.Text = "Yellow Wins!";
                chickenDinner.Foreground = Brushes.Crimson;
            }
            else if(lscore > bscore && lscore > gscore && lscore > rscore)
            {
                limeScore.Height = 130;
                limeScore.Width = 132;
                chickenDinner.Text = "Green Wins!";
                chickenDinner.Foreground = Brushes.Crimson;
            }
            else
            {
                redScore.Height = 76;
                redScore.Width = 79;
                blueScore.Height = 76;
                blueScore.Width = 79;
                goldScore.Height = 76;
                goldScore.Width = 79;
                limeScore.Height = 76;
                limeScore.Width = 79;
                chickenDinner.Text = "Nobody Wins.";
                chickenDinner.Foreground = Brushes.Crimson;
            }
            if (inplay == 2)
            {
                joeBox.Visibility = Visibility.Visible;
                goldScore.Visibility = Visibility.Collapsed;
                limeScore.Visibility = Visibility.Collapsed;
                joeBox.Height = 93;
                joeBox.Width = 96;
                jayBox.Height = 93;
                jayBox.Width = 96;
                jimBox.Height = 93;
                jimBox.Width = 96;
            }
            if (inplay == 3)
            {
                joeBox.Visibility = Visibility.Visible;
                limeScore.Visibility = Visibility.Collapsed;
            }
        }
    }
}
