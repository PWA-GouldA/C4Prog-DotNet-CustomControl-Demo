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

namespace Custom_Control_Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ChangeContent();
        }

        private void ChangeContent()
        {
            TitleLabel.Content = "TESTING";
            ContentLabel.Content = "9876";

            TestCard.CardTitle = "BOO";
            TestCard.CardContent = "1234";
            TestCard.CardBackground = "#FF00FF00";
            TestCard.CardBorderColour = "#99000000";
            TestCard.CardBorderWidth = "2";
            TestCard.CardCornerRadius = "10";
           
        }
    }
}
