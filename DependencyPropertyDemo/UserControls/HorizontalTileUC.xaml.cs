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

namespace DependencyPropertyDemo.UserControls
{
    /// <summary>
    /// Interaction logic for HorizontalTileUC.xaml
    /// </summary>
    public partial class HorizontalTileUC : UserControl
    {
        #region Fields

        // Here we register the dependency property. PrimaryColorProperty is the backing store for whatever value we put into the PrimaryColor attribute in XAML
        // The snippet (including C# property from further below) can be obtained by typing "propdp" and then hitting TAB twice

        public static readonly DependencyProperty PrimaryColorProperty =
            DependencyProperty.Register(
                "PrimaryColor", // Name under which we can address this property in XAML, it should always be the same identifier without the -Property prefix!
                typeof(string), // Type of the property
                typeof(HorizontalTileUC), // Type of the UC that carries this property
                new PropertyMetadata("White") // Optional default value
                );

        public static readonly DependencyProperty SecondaryColorProperty =
            DependencyProperty.Register("SecondaryColor", typeof(string), typeof(HorizontalTileUC), new PropertyMetadata("White"));

        public static readonly DependencyProperty TertiaryColorProperty =
            DependencyProperty.Register("TertiaryColor", typeof(string), typeof(HorizontalTileUC), new PropertyMetadata("White"));

        #endregion Fields

        #region Properties

        // We must define a C# property in the code-behind that can retrieve the value stored in PrimaryColorProperty from XAML and also set it there.
        // This is done via GetValue (cast needed) and SetValue as shown below
        // Now, we just need to set the binding in XAML

        public string PrimaryColor
        {
            get { return (string)GetValue(PrimaryColorProperty); }
            set { SetValue(PrimaryColorProperty, value); }
        }

        public string SecondaryColor
        {
            get { return (string)GetValue(SecondaryColorProperty); }
            set { SetValue(SecondaryColorProperty, value); }
        }

        public string TertiaryColor
        {
            get { return (string)GetValue(TertiaryColorProperty); }
            set { SetValue(TertiaryColorProperty, value); }
        }

        #endregion Properties

        #region Public Constructors

        public HorizontalTileUC()
        {
            InitializeComponent();
        }

        #endregion Public Constructors

    }
}
