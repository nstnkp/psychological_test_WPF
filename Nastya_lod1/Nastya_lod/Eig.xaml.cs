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

namespace Nastya_lod
{
    /// <summary>
    /// Логика взаимодействия для Eig.xaml
    /// </summary>
    public partial class Eig : Page
    {
        public Eig()
        {
            InitializeComponent();
        }

        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Этот ответ в тесте указывает на романтичность и мечтательность. Такие личности обладают творческим потенциалом, который при правильном подходе перерастает в настоящий талант.", "Результат");
        }

        private void Rectangle_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Женщина обращает на себя внимание внимательных и сконцентрированных людей. Это выбор целеустремленных, уверенных в себе, оптимистично настроенных", "Результат");
        }

        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Этот ответ в тесте указывает на романтичность и мечтательность. Такие личности обладают творческим потенциалом, который при правильном подходе перерастает в настоящий талант.", "Результат");
        }

        private void Label_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Женщина обращает на себя внимание внимательных и сконцентрированных людей. Это выбор целеустремленных, уверенных в себе, оптимистично настроенных", "Результат");

        }
    }
}
