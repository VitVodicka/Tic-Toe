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
        


        public MainWindow()
        {
            InitializeComponent();
            DataContext = b;
            b.init();
            


        }

        private void checking(object sender, RoutedEventArgs e)
        {
            
            RowChecking();

            SwitchingXO();
            b.CheckingAndCounting(arry);
            b.CountingFullness(arry);
            if (b.Tru == true)
            {
                ArrayRestarting();
            }


        }
        #region Switching X and O
        public void SwitchingXO()
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
            if ((arrayColumn0Row0.IsChecked == true) && ((arry[0, 0] == null) || (arry[0, 0] == "")))
            {
                arrayColumn0Row0.IsEnabled=false;
                arrayColumn0Row0.Content = krizek[0].ToString();
                arry[0, 0] = krizek[0].ToString();
            }
            if (arrayColumn1Row0.IsChecked == true && ((arry[1, 0] == null) || (arry[1, 0] == "")))
            {
                arrayColumn1Row0.IsEnabled = false;
                arrayColumn1Row0.Content = krizek[0].ToString();

                arry[1, 0] = krizek[0].ToString();
            }
            if (arrayColumn2Row0.IsChecked == true && ((arry[2, 0] == null) || (arry[2, 0] == "")))
            {
                arrayColumn2Row0.IsEnabled = false;
                arrayColumn2Row0.Content = krizek[0].ToString();

                arry[2, 0] = krizek[0].ToString();
            }
            if (arrayColumn0Row1.IsChecked == true && ((arry[0, 1] == null) || (arry[0, 1] == "")))
            {
                arrayColumn0Row1.IsEnabled = false;
                arrayColumn0Row1.Content = krizek[0].ToString();
                arry[0, 1] = krizek[0].ToString();
            }
            if (arrayColumn0Row2.IsChecked == true && ((arry[0, 2] == null) || (arry[0, 2] == "")))
            {
                arrayColumn0Row2.IsEnabled = false;
                arrayColumn0Row2.Content = krizek[0].ToString();
                arry[0, 2] = krizek[0].ToString();
            }

            if (arrayColumn1Row1.IsChecked == true && ((arry[1, 1] == null) || (arry[1, 1] == "")))
            {
                arrayColumn1Row1.IsEnabled = false;
                arrayColumn1Row1.Content = krizek[0].ToString();
                arry[1, 1] = krizek[0].ToString();
            }
            if (arrayColumn1Row2.IsChecked == true && ((arry[1, 2] == null) || (arry[1, 2] == "")))
            {
                arrayColumn1Row2.IsEnabled = false;
                arrayColumn1Row2.Content = krizek[0].ToString();
                arry[1, 2] = krizek[0].ToString();
            }
            if (arrayColumn2Row1.IsChecked == true && ((arry[2, 1] == null) || (arry[2, 1] == "")))
            {
                arrayColumn2Row1.IsEnabled = false;
                arrayColumn2Row1.Content = krizek[0].ToString();
                arry[2, 1] = krizek[0].ToString();
            }
            if (arrayColumn2Row2.IsChecked == true && ((arry[2, 2] == null) || (arry[2, 2] == "")))
            {
                arrayColumn2Row2.IsEnabled = false;
                arrayColumn2Row2.Content = krizek[0].ToString();
                arry[2, 2] = krizek[0].ToString();
            }


        }
        #endregion

        #region ArrayRestarting
        public void ArrayRestarting()
        {
            b.Tru = false;
            if (b.array != null)
            {

            
            for (int i = 0; (i < b.array.GetLength(0)); i++)//rows
            {
                for (int k = 0; k < b.array.GetLength(1); k++)//columns
                {
                    if ((i == 0) && (k == 0))
                    {
                        arrayColumn0Row0.IsChecked = false;
                            arry[0, 0] = null;
                        arrayColumn0Row0.Content = null;
                        arrayColumn0Row0.IsEnabled = true;


                    }
                    if ((i == 0) && (k == 1))
                    {
                        arrayColumn1Row0.IsChecked = false;
                            arry[0, 1] = null;
                            arrayColumn1Row0.Content = null;
                        arrayColumn1Row0.IsEnabled = true;
                    }
                    if ((i == 0) && (k == 2))
                    {
                        arrayColumn2Row0.IsChecked = false;
                            arry[0, 2] = null;
                            arrayColumn2Row0.Content = null;
                            arrayColumn2Row0.IsEnabled = true;
                        }
                    if ((i == 1) && (k == 0))
                    {
                        arrayColumn0Row1.IsChecked = false;
                            arry[1, 0] = null;
                            arrayColumn0Row1.Content = null;
                            arrayColumn0Row1.IsEnabled = true;
                        }
                    if ((i == 1) && (k == 1))
                    {
                        arrayColumn1Row1.IsChecked = false;
                            arry[1, 1] = null;
                            arrayColumn1Row1.Content = null;
                            arrayColumn1Row1.IsEnabled = true;
                        }
                    if ((i == 1) && (k == 2))
                    {
                        arrayColumn2Row1.IsChecked = false;
                            arry[1, 2] = null;
                            arrayColumn2Row1.Content = null;
                            arrayColumn2Row1.IsEnabled = true;
                        }
                    if ((i == 2) && (k == 0))
                    {
                        arrayColumn0Row2.IsChecked = false;
                            arry[2,0] = null;
                            arrayColumn0Row2.Content = null;
                            arrayColumn0Row2.IsEnabled = true;
                        }
                    if ((i == 2) && (k == 1))
                    {
                        arrayColumn1Row2.IsChecked = false;
                            arry[2,1] = null;
                            arrayColumn1Row2.Content = null;
                            arrayColumn1Row2.IsEnabled = true;
                        }
                    if ((i == 2) && (k == 2))
                    {
                        arrayColumn2Row2.IsChecked = false;
                            arry[2,2] = null;
                            arrayColumn2Row2.Content = null;
                            arrayColumn2Row2.IsEnabled = true;
                        }
                }
            }
            }
        }
        #endregion

        private void Record_Click(object sender, RoutedEventArgs e)
        {
            

            Background c = new Background(b.PlayerX, b.PlayerY, b.Tie, b.Timer);


            b.AddingToCollection(c);
        }

        private void load_Click(object sender, RoutedEventArgs e)
        {
            OpenPage z = new OpenPage();
            z.Show();
        }

        private void Restart(object sender, RoutedEventArgs e)
        {
            ArrayRestarting();
            b.Restart();
            turn.Text = "X turn";


        }

        private void doubleListClick(object sender, MouseButtonEventArgs e)
        {
            b.DoubleClick(record.SelectedIndex);
        }

        private void OpenPage(object sender, RoutedEventArgs e)
        {
            OpenPage p = new OpenPage();
            p.Show();
        }
        
    }
}
