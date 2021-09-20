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
    /// Логика взаимодействия для First.xaml
    /// </summary>
    public partial class First : Page
    {
        public First()
        {
            InitializeComponent();
        }

        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Девушки бросаются в глаза внимательным и сконцентрированным. Такая личность обладает отменной памятью и творческим складом ума. У вас отлично развито воображение и художественный вкус.", "Результат");

        }

        private void Rectangle_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Водопад видят уставшие или морально истощенные люди. Вам уже давно пора взять паузу и как следует отдохнуть. Скорее всего, вы много работаете и уже порядком устали. Такой стиль жизни приводит к стрессу и эмоциональному выгоранию, наличие которого можно определить с помощью психологического теста.", "Результат");

        }

        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Водопад видят уставшие или морально истощенные люди. Вам уже давно пора взять паузу и как следует отдохнуть. Скорее всего, вы много работаете и уже порядком устали. Такой стиль жизни приводит к стрессу и эмоциональному выгоранию, наличие которого можно определить с помощью психологического теста.", "Результат");

        }

        private void Label_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Девушки бросаются в глаза внимательным и сконцентрированным. Такая личность обладает отменной памятью и творческим складом ума. У вас отлично развито воображение и художественный вкус.", "Результат");

        }
    }
}
