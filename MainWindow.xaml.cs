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
using System.Data;
using System.Drawing;

namespace WebBrowser13._05._2019
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            webbrowser.Source = new Uri("https://www.google.ru/");

            
        }

        private void tabItemPlus_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            tabControl.Items.Insert(tabControl.Items.IndexOf(tabItemPlus), new TabItem { Header = "Google", Content = new WebBrowser { Source = new Uri("https://www.google.ru/") } });
        }
    }
}
