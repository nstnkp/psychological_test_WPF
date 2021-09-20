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
    /// Логика взаимодействия для Ten.xaml
    /// </summary>
    public partial class Ten : Page
    {
        public Ten()
        {
            InitializeComponent();
        }

        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Мужчина. Этот результат в тесте свидетельствует о сильном характере, настойчивости и уверенности. Такой человек не привык сомневаться в себе и своих поступках, все анализирует и принимает только взвешенные и рациональные решения.", "Результат");
        }

        private void Rectangle_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Женщина. Этот результат указывает на мягкость характера, креативность, нестандартность мыслей. Такие люди могут похвастаться  хорошим абстрактным мышлением, богатой фантазией и тонким восприятием искусства.", "Результат");
        }

        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Мужчина. Этот результат в тесте свидетельствует о сильном характере, настойчивости и уверенности. Такой человек не привык сомневаться в себе и своих поступках, все анализирует и принимает только взвешенные и рациональные решения.", "Результат");

        }

        private void Label_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Женщина. Этот результат указывает на мягкость характера, креативность, нестандартность мыслей. Такие люди могут похвастаться  хорошим абстрактным мышлением, богатой фантазией и тонким восприятием искусства.", "Результат");

        }
    }
}
