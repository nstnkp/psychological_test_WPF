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
    /// Логика взаимодействия для Fo.xaml
    /// </summary>
    public partial class Fo : Page
    {
        public Fo()
        {
            InitializeComponent();
        }

        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Водопад. Такой ответ указывает на технический склад ума. Наверняка вы обладаете хорошей памятью и внимательностью. Если это не так, то срочно займитесь их тренировкой. У вас отличный потенциал, который можно быстро развить.", "Результат");
        }

        private void Rectangle_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Девушка с длинными волосами. Ее видят люди с гуманитарным складом ума. Скорее всего, вам отлично даются гуманитарные науки, а работа связанна с творчеством. Такие личности ранимы, впечатлительны и чрезмерно подвержены стрессу. Узнайте, к чему он приводит и как от него избавиться.", "Результат");
        }

        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Водопад. Такой ответ указывает на технический склад ума. Наверняка вы обладаете хорошей памятью и внимательностью. Если это не так, то срочно займитесь их тренировкой. У вас отличный потенциал, который можно быстро развить.", "Результат");

        }

        private void Label_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Девушка с длинными волосами. Ее видят люди с гуманитарным складом ума. Скорее всего, вам отлично даются гуманитарные науки, а работа связанна с творчеством. Такие личности ранимы, впечатлительны и чрезмерно подвержены стрессу. Узнайте, к чему он приводит и как от него избавиться.", "Результат");

        }
    }
}
