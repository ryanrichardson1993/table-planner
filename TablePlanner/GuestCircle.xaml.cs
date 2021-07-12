using System.Windows;
using System.Windows.Controls;

namespace TablePlanner
{
    public partial class GuestCircle : UserControl
    {
        public GuestCircle()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty GuestNameProperty = DependencyProperty.Register("GuestName", typeof(string), typeof(GuestCircle), new PropertyMetadata(string.Empty));
        public static readonly DependencyProperty AlcoholProperty = DependencyProperty.Register("GuestIsDrinkingAlcohol", typeof(bool), typeof(GuestCircle), new PropertyMetadata(false));
        public static readonly DependencyProperty HighChairProperty = DependencyProperty.Register("GuestNeedsHighChair", typeof(bool), typeof(GuestCircle), new PropertyMetadata(false));

        public string GuestName
        {
            get => (string)GetValue(GuestNameProperty);
            set => SetValue(GuestNameProperty, value);
        }

        public bool GuestIsDrinkingAlcohol
        {
            get => (bool)GetValue(AlcoholProperty);
            set => SetValue(AlcoholProperty, value);
        }

        public bool GuestNeedsHighChair
        {
            get => (bool) GetValue(HighChairProperty);
            set => SetValue(HighChairProperty, value);
        }
    }
}
