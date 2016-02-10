using System;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace EasyPointTracker
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        private int defaultValues = 50;
     
        public MainPage()
        {
            this.InitializeComponent();

        }

        public void ImgSwap()
        {
         
            Image img = new Image();
            img.Source = new BitmapImage(new Uri("ms-appx:///Assets/minus-alt.png"));
                       
        }

        // 1st player score panel
        private void downClick1(object sender, RoutedEventArgs e)
        {
            int downScore = Convert.ToInt32(scorePanelOne.Text);

            if (Convert.ToInt32(scorePanelOne.Text) <= defaultValues)
            {
                downScore -= 1;
                scorePanelOne.Text = downScore.ToString();
                scoreColors();
            }
            else
            {
                downScore -= 1;
                scorePanelOne.Text = downScore.ToString();
                scoreColors();
            }
            ImgSwap();
        }

        private void upClick1(object sender, RoutedEventArgs e)
        {
            int upScore = Convert.ToInt32(scorePanelOne.Text);

            if (Convert.ToInt32(scorePanelOne.Text) >= defaultValues)
            {
                upScore += 1;
                scorePanelOne.Text = upScore.ToString();
                scoreColors();
            }
            else
            {
                upScore += 1;
                scorePanelOne.Text = upScore.ToString();
                scoreColors();
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
                scoreColors();
            }
            else
            {
                downScore2 -= 1;
                scorePanelTwo.Text = downScore2.ToString();
                scoreColors();
            }
        }

        private void upClick2(object sender, RoutedEventArgs e)
        {
            int upScore2 = Convert.ToInt32(scorePanelTwo.Text);

            if (Convert.ToInt32(scorePanelTwo.Text) >= defaultValues)
            {
                upScore2 += 1;
                scorePanelTwo.Text = upScore2.ToString();
                scoreColors();
            }
            else
            {
                upScore2 += 1;
                scorePanelTwo.Text = upScore2.ToString();
                scoreColors();
            }
        }

        // compare score panel colors
        public void scoreColors()
        {
            if (scorePanelOne.Text == scorePanelTwo.Text || scorePanelTwo.Text == scorePanelOne.Text)
            {
                scorePanelOne.Foreground = new SolidColorBrush(Colors.Blue);
                scorePanelTwo.Foreground = new SolidColorBrush(Colors.Blue);
            }


            if (Convert.ToInt32(scorePanelOne.Text) < Convert.ToInt32(scorePanelTwo.Text))
            {
                scorePanelOne.Foreground = new SolidColorBrush(Colors.Red);
                scorePanelTwo.Foreground = new SolidColorBrush(Colors.Yellow);
            }

            if (Convert.ToInt32(scorePanelTwo.Text) < Convert.ToInt32(scorePanelOne.Text))
            {
                scorePanelTwo.Foreground = new SolidColorBrush(Colors.Red);
                scorePanelOne.Foreground = new SolidColorBrush(Colors.Yellow);
            }

            //(scorePanelOne.Text == scorePanelTwo.Text)
            //{
            //    scorePanelOne.Foreground = new SolidColorBrush(Colors.Blue);
            //}
        }
        // reset score panels to defaults
        private void resetScorePanelOne(object sender, DoubleTappedRoutedEventArgs e)
        {
            scorePanelOne.Text = defaultValues.ToString();
            scoreColors();

        }
        private void resetScorePanelTwo(object sender, DoubleTappedRoutedEventArgs e)
        {
            scorePanelTwo.Text = defaultValues.ToString();
            scoreColors();
        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(About));
        }


        // somehow it's not pulling variable...must figure out. 

        //private void resetScorePanels(object sender, RoutedEventArgs e)
        //{
        //    scorePanelOne.Text = initialScorePanelOne.ToString();

        //}



    }
}
