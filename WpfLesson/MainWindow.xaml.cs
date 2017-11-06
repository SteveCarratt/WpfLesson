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
            var grid = Content as Grid;
            grid.Children.Add(new TextBlock()
                                       {
                                           VerticalAlignment = VerticalAlignment.Center,
                                           HorizontalAlignment = HorizontalAlignment.Center,
                                           FontSize = 72,
                                           Text = "Hello, WPF!"
                                       });
        }
    }
}
