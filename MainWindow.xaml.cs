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
            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void checking(object sender, RoutedEventArgs e)
        {
            RowChecking();
           
            Switching();
            b.Checking(arry);

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
    }
}
