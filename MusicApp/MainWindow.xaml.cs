using System.Windows;
using System.Windows.Input;


namespace MusicApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if( e.ChangedButton == MouseButton.Left )
            {
                this.DragMove();
            }
        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
    }
}
