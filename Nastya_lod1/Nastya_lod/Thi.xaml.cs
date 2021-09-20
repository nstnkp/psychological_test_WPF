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
    /// Логика взаимодействия для Thi.xaml
    /// </summary>
    public partial class Thi : Page
    {
        public Thi()
        {
            InitializeComponent();
        }

        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Ворон. Такой ответ дают люди, пребывающие в плохом настроении. Подумайте, что вас угнетает и как исправить ситуацию. Высока вероятность, что вы сильно устали и нуждаетесь в длительном отдыхе. Требуется перезагрузка и смена обстановки. Это поможет пересмотреть жизненные цели и восстановить энергию для дальнейшей деятельности.", "Результат");
        }

        private void Rectangle_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Голова. Такой результат характеризует личность, как стрессо устойчивую и психически уравновешенную. Вы находитесь в устойчивом нервно психическом состоянии, не склонны к истерикам и неконтролируемому поведению. Без веской на то причины вас чрезвычайно сложно вывести из себя или заставить нервничать.", "Результат");
        }

        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Ворон. Такой ответ дают люди, пребывающие в плохом настроении. Подумайте, что вас угнетает и как исправить ситуацию. Высока вероятность, что вы сильно устали и нуждаетесь в длительном отдыхе. Требуется перезагрузка и смена обстановки. Это поможет пересмотреть жизненные цели и восстановить энергию для дальнейшей деятельности.", "Результат");

        }

        private void Label_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Голова. Такой результат характеризует личность, как стрессо устойчивую и психически уравновешенную. Вы находитесь в устойчивом нервно психическом состоянии, не склонны к истерикам и неконтролируемому поведению. Без веской на то причины вас чрезвычайно сложно вывести из себя или заставить нервничать.", "Результат");

        }
    }
}
