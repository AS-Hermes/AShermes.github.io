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
using wpftest.Models;

namespace wpftest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            /*this.DataContext = new User() { Name = "John Doe", Age = 30 };*/
        }

        /*private void myButton_Click(object sender, RoutedEventArgs e)
        {
            myTextBlock.Text = myTextBox.Text;
        }*/
    }
}