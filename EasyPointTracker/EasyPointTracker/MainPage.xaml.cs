using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace EasyPointTracker
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public int initialScorePanelOne = 50;
        private int initialScorePanelTwo = 50;

        public MainPage()
        {
            this.InitializeComponent();
     
        }

        private void Down_Click(object sender, RoutedEventArgs e)
        {
            initialScorePanelOne -= 1;
            scorePanelOne.Text = initialScorePanelOne.ToString();
        }

        private void Up_Click(object sender, RoutedEventArgs e)
        {
            initialScorePanelOne += 1;
            scorePanelOne.Text = initialScorePanelOne.ToString();
        }

        private void resetScorePanelOne(object sender, DoubleTappedRoutedEventArgs e)
        {
            scorePanelOne.Text = "50";
          //  scorePanelOne.Foreground = new SolidColorBrush(Windows.UI.Colors.YellowGreen);
        }
        
        // somehow it's not pulling variable...must figure out. 

        private void resetScorePanels(object sender, RoutedEventArgs e)
        {
            scorePanelOne.Text = initialScorePanelOne.ToString();
            
        }
    }
}
