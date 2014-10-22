using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Demo04
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public async Task Sum(int x, int y)
        {
            await Task.Run(() =>
            {               
                Thread.Sleep(5000);
            });
            Output.Items.Add("After Run Task");
        }

        public async Task CallSumAsync()
        {
            await Sum(3, 5);
            Output.Items.Add("Sum Finish");
        }

        private async void StartButton_Click(object sender, RoutedEventArgs e)
        {
            await CallSumAsync();
            Output.Items.Add("Process Finish");
        }

        private void OtherActionButton_Click(object sender, RoutedEventArgs e)
        {
            Output.Items.Add("Another Action Executed");
        }
    }
}
