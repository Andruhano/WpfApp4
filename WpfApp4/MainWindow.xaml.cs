using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp4
{
    public partial class MainWindow : Window
    {
        public static readonly RoutedCommand ChangeColorCommand = new RoutedCommand();

        public MainWindow()
        {
            InitializeComponent();

            CommandBinding binding = new CommandBinding(ChangeColorCommand, ExecuteChangeColor);
            this.CommandBindings.Add(binding);
        }

        private void ExecuteChangeColor(object sender, ExecutedRoutedEventArgs e)
        {
            if (Keyboard.FocusedElement is Control control)
            {
                control.Background = Brushes.Red;
            }
        }
    }
}