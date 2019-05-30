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

namespace CulminatingProblemJ4FavouriteTimes
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

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            int D;
            int.TryParse(DInput.Text, out D);
            int total = 0;
            int startHours = 1;
            int startMinutes = 00;
            int currentHours;
            int currentMinutes;
            int[] hourtimes = {12,1,1,1,1,1,2,2,2,2,2,3,3,3,3,
                4,4,4,4,5,5,5,6,6,6,7,7,8,8,9,11 };
            int[] minutetimes = { 34, 11, 23, 35, 47, 59, 10, 22, 34, 46,
                58, 21, 33, 45, 57, 20, 32, 44, 56, 31, 43, 55, 30, 42, 54, 41, 53, 40, 52, 51, 11 };
            if (D <= 60)
            {
                lblOutput.Content = "1";
            }
            else if (D <= 719)
            {
                currentHours = 0;
                currentMinutes = D % 60;
                //No decimals for int
                currentHours += D / 60;
                
                for (int i = 1; i < 32; i++)
                {
                    if (currentHours >= hourtimes[i - 1] && currentMinutes >= minutetimes[i -1] )
                    {
                        if (currentMinutes < 10)
                        {
                            lblOutput.Content = "Current time: " + currentHours + ":" + "0" + currentMinutes + " total: " + i;
                        }
                        else
                        {
                            lblOutput.Content = "Current time: " + currentHours + ":" + currentMinutes + " total: " + i;
                        }
                    }
                }
            }
            else if (D > 719)
            {
                int howManyTimes;
                currentHours = 0;
                currentMinutes = D % 60;
                //No decimals for int
                currentHours += D / 60;
                howManyTimes = (currentHours - 12) / 12;


                for (int i = 1; i < 32 * howManyTimes; i++)
                {
                    if (currentHours >= hourtimes[i - 1] && currentMinutes >= minutetimes[i - 1])
                    {
                        if (currentMinutes < 10)
                        {
                            lblOutput.Content = "Current time: " + currentHours + ":" + "0" + currentMinutes + " total: " + i;
                        }
                        else
                        {
                            lblOutput.Content = "Current time: " + currentHours + ":" + currentMinutes + " total: " + i;
                        }
                    }
                }

            }
        }
    }
}
