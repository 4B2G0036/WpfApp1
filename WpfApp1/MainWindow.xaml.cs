using System.Windows;
using System.Windows.Controls;

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

        private void Text_box_TextChanged(object sender, TextChangedEventArgs e)
        {
            var targetTextBox = sender as TextBox;
            int amount;
            bool Success = int.TryParse(targetTextBox.Text, out amount);
            if (!Success)
            {
                MessageBox.Show("請輸入正整數");
            }
            else if (amount <= 0)
            {
                MessageBox.Show("請輸入正整數");
            }
            else
            {
                var targetstackPanel = targetTextBox.Parent as StackPanel;
                var targetlabel = targetstackPanel.Children[0] as Label;
                var drinkname = targetlabel.Content.ToString();

                ResultTextblock.Text +=  $"您選擇了 {drinkname}，數量{amount}杯\n";
            }
        }
    }
}