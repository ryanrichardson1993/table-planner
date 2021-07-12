using System.Windows;
using System.Windows.Controls;

namespace TablePlanner
{
    public partial class TableShape : UserControl
    {
        public TableShape()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty GuestCountProperty = DependencyProperty.Register("GuestCount", typeof(string), typeof(TableShape), new PropertyMetadata(string.Empty));

        public string GuestCount
        {
            get => (string)GetValue(GuestCountProperty);
            set => SetValue(GuestCountProperty, value);
        }
    }
}
