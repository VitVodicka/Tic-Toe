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
using System.Windows.Shapes;

namespace Tic_Toe
{
    /// <summary>
    /// Interakční logika pro OpenPage.xaml
    /// </summary>
    public partial class OpenPage : Window
    {
        File f = new File();
        public OpenPage()
        {
            InitializeComponent();
            DataContext = f;
        }

        
    }
}
