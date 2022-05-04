using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Tic_Toe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Background b = new Background();
        string[,] arry = new string[3, 3];
        Stopwatch stop = new Stopwatch();


        public MainWindow()
        {
            InitializeComponent();
            DataContext = b;
            
            stop.Start();
            
            
        }

        private void checking(object sender, RoutedEventArgs e)
        {
            RowChecking();
           
            Switching();
            b.Checking(arry);
            b.Full(arry);
            if (b.Tru == true)
            {
                ArrayChecking();
            }
            

        }
        #region Switching X and Y
        public void Switching()
        {
            if (turn.Text == "X turn")
            {
                turn.Text = "Y turn";
            }
            else if (turn.Text == "Y turn")
            {
                turn.Text = "X turn";
            }
        }
        #endregion

        #region Row checking
        public void RowChecking()
        {
            char[] krizek = turn.Text.ToCharArray();//returns first letter of title

            //if box is checked and if it has something then it will has a letter of the titile
            if ((arrayColumn0Row0.IsChecked == true)&&((arry[0,0]==null)||(arry[0, 0] == "")))
            {
                arry[0, 0] = krizek[0].ToString();   
            }
            if (arrayColumn1Row0.IsChecked == true && ((arry[1, 0] == null) || (arry[1, 0] == "")))
            {

                
                arry[1, 0] = krizek[0].ToString();
            }
            if (arrayColumn2Row0.IsChecked == true && ((arry[2, 0] == null) || (arry[2, 0] == "")))
            {

                
                arry[2, 0] = krizek[0].ToString();
            }
            if (arrayColumn0Row1.IsChecked == true && ((arry[0, 1] == null) || (arry[0, 1] == "")))
            {
                
                arry[0, 1] = krizek[0].ToString();
            }
            if (arrayColumn0Row2.IsChecked == true && ((arry[0, 2] == null) || (arry[0, 2] == "")))
            {
                
                arry[0, 2] = krizek[0].ToString();
            }

            if (arrayColumn1Row1.IsChecked == true && ((arry[1, 1] == null) || (arry[1, 1] == "")))
            {
                
                arry[1, 1] = krizek[0].ToString();
            }
            if (arrayColumn1Row2.IsChecked == true && ((arry[1, 2] == null) || (arry[1, 2] == "")))
            {
                
                arry[1, 2] = krizek[0].ToString();
            }
            if (arrayColumn2Row1.IsChecked == true && ((arry[2, 1] == null) || (arry[2, 1] == "")))
            {
                
                arry[2, 1] = krizek[0].ToString();
            }
            if (arrayColumn2Row2.IsChecked == true && ((arry[2, 2] == null) || (arry[2, 2] == "")))
            {
                
                arry[2, 2] = krizek[0].ToString();
            }


        }
        #endregion

        #region ArrayChecking
        public void ArrayChecking()
        {
            b.Tru = false;
            for (int i = 0; i < b.array.GetLength(0); i++)//rows
            {
                for (int k = 0; k < b.array.GetLength(1); k++)//columns
                {
                    if ((i == 0) && (k == 0))
                    {
                        arrayColumn0Row0.IsChecked = false;
                        
                        
                    }
                    if ((i == 0) && (k == 1))
                    {
                        arrayColumn1Row0.IsChecked = false;
                        
                    }
                    if ((i == 0) && (k == 2))
                    {
                        arrayColumn2Row0.IsChecked = false;
                        
                    }
                    if ((i == 1) && (k == 0))
                    {
                        arrayColumn0Row1.IsChecked = false;
                    }
                    if ((i == 1) && (k == 1))
                    {
                        arrayColumn1Row1.IsChecked = false;
                    }
                    if ((i == 1) && (k == 2))
                    {
                        arrayColumn2Row1.IsChecked = false;
                    }
                    if ((i == 2) && (k == 0))
                    {
                        arrayColumn0Row2.IsChecked = false;
                    }
                    if ((i == 2) && (k == 1))
                    {
                        arrayColumn1Row2.IsChecked = false;
                    }
                    if ((i == 2) && (k == 2))
                    {
                        arrayColumn2Row2.IsChecked = false;
                    }
                }
            }
        }
        #endregion

        private void Record_Click(object sender, RoutedEventArgs e)
        {
            stop.Stop();
            
            Background c = new Background(b.PlayerX, b.PlayerY, b.Tie,Math.Round(stop.Elapsed.TotalSeconds,2).ToString());
            
            
            b.AddingToCollection(c);
        }

        private void load_Click(object sender, RoutedEventArgs e)
        {
            OpenPage z = new OpenPage();
            z.Show();
        }

        private void Restart(object sender, RoutedEventArgs e)
        {
            ArrayChecking();
            b.Restart();
            stop.Start();

        }
    }
}
