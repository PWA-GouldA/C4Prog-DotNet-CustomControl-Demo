using System.Windows;
using System.Windows.Controls;

namespace Custom_Control_Demo
{
    /// <summary>
    /// Interaction logic for SimpleCard.xaml
    /// </summary>
    public partial class SimpleCard : UserControl
    {
        public SimpleCard()
        {
            InitializeComponent();
            CardGrid.DataContext = this;
        }
        
        #region CardTitle DP
        public string CardTitle
        {
            set { SetValue(TitleText, value); }
        }
        public static readonly DependencyProperty TitleText =
            DependencyProperty.Register(
                "CardTitle",            // XAML/Property name
                typeof(string),         // Type of content in properry
                typeof(SimpleCard),     // Bound to this control
                new PropertyMetadata(null));
        #endregion

        #region CardContent DP
        public string CardContent
        {
            set { SetValue(ContentText, value); }
        }
        public static readonly DependencyProperty ContentText =
            DependencyProperty.Register(
                "CardContent",
                typeof(string),
                typeof(SimpleCard),
                new PropertyMetadata(null));
        #endregion

        #region CardBackground DP
        public string CardBackground
        {
            set { SetValue(ColourBG, value); }
        }
        public static readonly DependencyProperty ColourBG =
            DependencyProperty.Register(
                "CardBackground",
                typeof(string),
                typeof(SimpleCard),
                new PropertyMetadata(null));
        #endregion

        #region CardBorderColour DP
        public string CardBorderColour
        {
            set { SetValue(ColourBdr, value); }
        }
        public static readonly DependencyProperty ColourBdr =
            DependencyProperty.Register(
                "CardBorderColour",
                typeof(string),
                typeof(SimpleCard),
                new PropertyMetadata(null));
        #endregion

        #region CardBorderWidth DP
        public string CardBorderWidth
        {
            set { SetValue(WidthBdr, value); }
        }
        public static readonly DependencyProperty WidthBdr =
            DependencyProperty.Register(
                "CardBorderWidth",
                typeof(string),
                typeof(SimpleCard),
                new PropertyMetadata(null));
        #endregion

        #region CardCornerRadius DP
        public string CardCornerRadius
        {
            set { SetValue(CornerRad, value); }
        }
        public static readonly DependencyProperty CornerRad =
            DependencyProperty.Register(
                "CardCornerRadius",
                typeof(string),
                typeof(SimpleCard),
                new PropertyMetadata(null));
        #endregion
    }
}
