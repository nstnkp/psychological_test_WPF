using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Nastya_lod
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

       
        private void image3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Test ts = new Test(1);
            ts.Show();
            this.Hide();
        }

        private void image4_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Test ts = new Test(2);
            ts.Show();
            this.Hide();
        }

        private void image5_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Test ts = new Test(3);
            ts.Show();
            this.Hide();
        }

        private void image6_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Test ts = new Test(4);
            ts.Show();
            this.Hide();
        }

        private void image7_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Test ts = new Test(5);
            ts.Show();
            this.Hide();
        }

        private void image8_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Test ts = new Test(6);
            ts.Show();
            this.Hide();
        }

        private void image9_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Test ts = new Test(7);
            ts.Show();
            this.Hide();
        }

        private void image10_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Test ts = new Test(8);
            ts.Show();
            this.Hide();
        }

        private void image11_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Test ts = new Test(9);
            ts.Show();
            this.Hide();
        }

        private void image12_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Test ts = new Test(10);
            ts.Show();
            this.Hide();
        }
    }
}
