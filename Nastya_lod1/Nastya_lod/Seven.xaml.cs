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
    /// Логика взаимодействия для Seven.xaml
    /// </summary>
    public partial class Seven : Page
    {
        public Seven()
        {
            InitializeComponent();
        }

        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Череп. Такой ответ теста свидетельствует о наличие грустных мыслей, а возможно даже и депрессии.Высока вероятность того, что в данный момент вы чем-то расстроены или пребываете в затруднительном положении. Помните, что после черной полосы всегда наступает «белый» период. А большинство проблем может вовсе пропасть, если вы начнете к ним иначе относиться.", "Результат");
        }

        private void Rectangle_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Девушка. Ее видят впечатлительные и глубокие личности. Такие люди достаточно ранимы в глубине души, хоть могут и сами этого не признавать. Вас легко обидеть неосторожным словом или замечанием.", "Результат");
        }

        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Череп. Такой ответ теста свидетельствует о наличие грустных мыслей, а возможно даже и депрессии.Высока вероятность того, что в данный момент вы чем-то расстроены или пребываете в затруднительном положении. Помните, что после черной полосы всегда наступает «белый» период. А большинство проблем может вовсе пропасть, если вы начнете к ним иначе относиться.", "Результат");

        }

        private void Label_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Девушка. Ее видят впечатлительные и глубокие личности. Такие люди достаточно ранимы в глубине души, хоть могут и сами этого не признавать. Вас легко обидеть неосторожным словом или замечанием.", "Результат");

        }
    }
}
