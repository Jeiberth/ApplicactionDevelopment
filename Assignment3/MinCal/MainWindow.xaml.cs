using MinCal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace MinCal
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
        public BankCharges B = new BankCharges();

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            double balance = double.Parse(inpA.Text);
            int checks = int.Parse(inpB.Text);
            Res.Text = B.MonthServFee(balance, checks).ToString();
        }
    }
}
