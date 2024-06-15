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
using static System.Windows.Markup.XamlReader;


namespace WpfLesson1_bvv
{
    public partial class MainWindow : System.Windows.Window
    {
        public const System.String LOGIN = "admin";
        public const System.String PASS = "123456";

        public MainWindow()
        {
            InitializeComponent();
        }

        public void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            if (loginTextBox.Text.Equals(LOGIN) || passPasswordBox.Password.Equals(PASS))
            {
                MessageBox.Show("Authorization successful!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Authorization failed!", "Failed", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public void ExitButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            MessageBox.Show("BYE BYE");
            Close();
        }
    }
}
