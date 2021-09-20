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
    /// Логика взаимодействия для Ni.xaml
    /// </summary>
    public partial class Ni : Page
    {
        public Ni()
        {
            InitializeComponent();
        }

        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Бабочка указывает, что вы в душе все еще юный мечтатель, который верит в чудеса. У вас богатое воображение и хороший вкус.", "Результат");
        }

        private void Rectangle_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Скрипка говорит о рассудительности и надежности. Такие люди являются хорошими сотрудниками на рабочем месте и отличными партнерами в личных отношениях.", "Результат");
        }

        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Бабочка указывает, что вы в душе все еще юный мечтатель, который верит в чудеса. У вас богатое воображение и хороший вкус.", "Результат");

        }

        private void Label_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Скрипка говорит о рассудительности и надежности. Такие люди являются хорошими сотрудниками на рабочем месте и отличными партнерами в личных отношениях.", "Результат");

        }
    }
}
