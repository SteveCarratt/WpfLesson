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

namespace WpfLesson
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new object[]{new Type1(), new Type2(), new Type1()};
        }

        private void MainWindow_OnMouseEnter(object sender, MouseEventArgs e) { Background = Brushes.DarkSalmon; }

        private void MainWindow_OnMouseLeave(object sender, MouseEventArgs e) { Background = Brushes.White; }
    }

    public class Type1
    {
        
    }

    public class Type2
    {
        
    }
}
