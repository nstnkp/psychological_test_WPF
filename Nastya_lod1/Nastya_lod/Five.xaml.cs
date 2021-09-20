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
    /// Логика взаимодействия для Five.xaml
    /// </summary>
    public partial class Five : Page
    {
        public Five()
        {
            InitializeComponent();
        }

        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Череп. Такой результат указывает на наличие мрачных, депрессивных мыслей. Вас что-то сильно беспокоит или вы смотрите на мир с недоверием. Ожидание беды действительно может привлечь ее в вашу жизнь. Не позволяйте грустным мыслям завладеть вниманием. Человеку, увидевшему на этом изображении череп, желательно пройти тест на склонность к суициду", "Результат");
        }

        private void Rectangle_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Дети. Такой ответ дают оптимисты и мечтатели по жизни. Если вы видите детей с шариками, значит с уверенностью смотрите в завтрашний день и ждете от жизни больше хорошего, чем плохого.", "Результат");
        }

        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Череп. Такой результат указывает на наличие мрачных, депрессивных мыслей. Вас что-то сильно беспокоит или вы смотрите на мир с недоверием. Ожидание беды действительно может привлечь ее в вашу жизнь. Не позволяйте грустным мыслям завладеть вниманием. Человеку, увидевшему на этом изображении череп, желательно пройти тест на склонность к суициду", "Результат");

        }

        private void Label_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Дети. Такой ответ дают оптимисты и мечтатели по жизни. Если вы видите детей с шариками, значит с уверенностью смотрите в завтрашний день и ждете от жизни больше хорошего, чем плохого.", "Результат");

        }
    }
}
