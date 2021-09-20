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
using System.Windows.Shapes;

namespace Nastya_lod
{
    /// <summary>
    /// Логика взаимодействия для Test.xaml
    /// </summary>
    public partial class Test : Window
    {
        public int A;
        public Test(int a)
        {
            InitializeComponent();
            A = a;
        }


        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Hide();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            switch (A)
            {
                case 1:
                    Main.Content = new First();
                    break;
                case 2:
                    Main.Content = new Second();    
                    break;
                case 3:
                    Main.Content = new Thi();
                    break;
                case 4:
                    Main.Content = new Fo();
                    break;
                case 5:
                    Main.Content = new Five();
                    break;
                case 6:
                    Main.Content = new Six();
                    break;
                case 7:
                    Main.Content = new Seven();
                    break;
                case 8:
                    Main.Content = new Eig();
                    break;
                case 9:
                    Main.Content = new Ni();
                    break;
                case 10:
                    Main.Content = new Ten();
                    break;

                default:
                    
                    break;
            }
        }
    }
}
