using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace EasyPointTracker
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        private int defaultValues = 50;
        //private int initialScorePanelOne = 50;
        //private int initialScorePanelTwo = 50;
        
        public MainPage()
        {
            this.InitializeComponent();
     
        }
        
        // 1st player score panel
        private void downClick1(object sender, RoutedEventArgs e)
        {
            int downScore = Convert.ToInt32(scorePanelOne.Text);

            if (Convert.ToInt32(scorePanelOne.Text) <= defaultValues)
            {
                downScore -= 1;
                scorePanelOne.Text = downScore.ToString();
            } else
            {
                downScore -= 1;
                scorePanelOne.Text = downScore.ToString();
            }
            //int anInteger;
            //anInteger = Convert.ToInt32(textBox1.Text);
            //anInteger = int.Parse(textBox1.Text);

        }

        private void upClick1(object sender, RoutedEventArgs e)
        {
            int upScore = Convert.ToInt32(scorePanelOne.Text); 

            if (Convert.ToInt32(scorePanelOne.Text) >= defaultValues)
            {
                upScore += 1;
                scorePanelOne.Text = upScore.ToString();
            } else
            {
                upScore += 1;
                scorePanelOne.Text = upScore.ToString();
            }
        }

        // 2nd player score panel
        private void downClick2(object sender, RoutedEventArgs e)
        {
            int downScore2 = Convert.ToInt32(scorePanelTwo.Text);

            if (Convert.ToInt32(scorePanelTwo.Text) <= defaultValues)
            {
                downScore2 -= 1;
                scorePanelTwo.Text = downScore2.ToString();
            }
            else
            {
                downScore2 -= 1;
                scorePanelTwo.Text = downScore2.ToString();
            }
        }

        private void upClick2(object sender, RoutedEventArgs e)
        {
            int upScore2 = Convert.ToInt32(scorePanelTwo.Text);

            if (Convert.ToInt32(scorePanelTwo.Text) >= defaultValues)
            {
                upScore2 += 1;
                scorePanelTwo.Text = upScore2.ToString();

            }
            else
            {
                upScore2 += 1;
                scorePanelTwo.Text = upScore2.ToString();
            }
        }

        // reset score panels to defaults
        private void resetScorePanelOne(object sender, DoubleTappedRoutedEventArgs e)
        {
            scorePanelOne.Text = defaultValues.ToString();

        }
        private void resetScorePanelTwo(object sender, DoubleTappedRoutedEventArgs e)
        {
            scorePanelTwo.Text = defaultValues.ToString();
        }


        // somehow it's not pulling variable...must figure out. 

        //private void resetScorePanels(object sender, RoutedEventArgs e)
        //{
        //    scorePanelOne.Text = initialScorePanelOne.ToString();
            
        //}



    }
}
