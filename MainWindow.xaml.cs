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
using System.Windows.Threading;

namespace Wpf_pruebaNet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public DispatcherTimer timer;

        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(5);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            MessageBox.Show("Disparo del timer");
        }

        private void MiButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Has apretado el boton");
        }

        protected override void OnClosed(EventArgs e) {


            timer.Stop();
            timer.Tick -= Timer_Tick;
            timer = null;

        
        }



    }
}