using Microsoft.VisualBasic;
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

namespace WpfApp1
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
        List<int> primes = new List<int>();
        private void MyButton_Click(object sender, RoutedEventArgs e)
        {
            int n;
            bool IsSuccess = int.TryParse(MyTextBox.Text, out n);
            if (!IsSuccess)
            {
                MessageBox.Show("請輸入整數", "錯誤");
            }
            else if (n < 2)
            {
                MessageBox.Show("請輸入大於等於2的整數", "錯誤");
            }
            else
            {
                string primetext = $"小於等於{n}的質數有 : ";
                for (int i = 2; i <= n; i++)
                {
                    if (IsPrime(i)) primes.Add(i);
                }
                foreach (var p in primes) {
                    primetext += p + " ";
                }
                MyTextBlock.Text = primetext;
            }
        }

        private bool IsPrime(int p)
        {
            for (int i = 2; i < p; i++)
            {
                if ((p % i) == 0) return false;
            }
            return true;
        }
    }
}
    
