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
    /// Логика взаимодействия для Second.xaml
    /// </summary>
    public partial class Second : Page
    {
        public Second()
        {
            InitializeComponent();
        }

        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Лес видят романтики и мечтатели. Такие личности сосредоточены на своем внутреннем мире и часто находятся под воздействием фантазий. Вы до сих пор в глубине души верите в чудеса и знаете что рано или поздно с вами тоже произойдет невероятное приключение.", "Результат");

        }

        private void Rectangle_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Город. Если именно высотки бросились в глаза в первую очередь, значит вы общительный и целеустремленный человек. Такие личности чаще всего добиваются успеха в начатом деле и являются победителями по жизни. С другой стороны, этот выбор указывает на скрытые тревоги. Узнайте, что вы в себе подавляете с помощью этого онлайн теста.", "Результат");

        }

        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Лес видят романтики и мечтатели. Такие личности сосредоточены на своем внутреннем мире и часто находятся под воздействием фантазий. Вы до сих пор в глубине души верите в чудеса и знаете что рано или поздно с вами тоже произойдет невероятное приключение.", "Результат");

        }

        private void Label_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Город. Если именно высотки бросились в глаза в первую очередь, значит вы общительный и целеустремленный человек. Такие личности чаще всего добиваются успеха в начатом деле и являются победителями по жизни. С другой стороны, этот выбор указывает на скрытые тревоги. Узнайте, что вы в себе подавляете с помощью этого онлайн теста.", "Результат");

        }
    }
}
