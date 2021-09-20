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
    /// Логика взаимодействия для Six.xaml
    /// </summary>
    public partial class Six : Page
    {
        public Six()
        {
            InitializeComponent();
        }

        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Закат видят оптимисты и романтики. Вы обладаете тонким художественным вкусом и замечаете даже малейшие мелочи. Внимательность, любознательность, позитив – это ваши главные качества, которые определил тест.", "Результат");
        }

        private void Rectangle_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Яйцо чаще замечают уверенные в себе и целеустремленные личности. Таких людей часто называют прагматиками или реалистами. Они обладают хорошей памятью, высокой концентрацией внимания и аналитическим складом ума.", "Результат");
        }

        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Закат видят оптимисты и романтики. Вы обладаете тонким художественным вкусом и замечаете даже малейшие мелочи. Внимательность, любознательность, позитив – это ваши главные качества, которые определил тест.", "Результат");

        }

        private void Label_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Яйцо чаще замечают уверенные в себе и целеустремленные личности. Таких людей часто называют прагматиками или реалистами. Они обладают хорошей памятью, высокой концентрацией внимания и аналитическим складом ума.", "Результат");

        }
    }
}
