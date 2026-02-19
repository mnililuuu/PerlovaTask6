using System.Windows;

namespace Group4337
{
    public partial class MainWindow : Window
    {
        public MainWindow()
            => InitializeComponent();

        private void CreaterWindowButton_Click(object sender, RoutedEventArgs e)
        {
            CreaterWindow window = new CreaterWindow();
            window.Show();
            this.Close();
        }
    }
}