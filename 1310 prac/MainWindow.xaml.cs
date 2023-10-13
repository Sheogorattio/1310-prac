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

namespace _1310_prac
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] uriArr = { "lang.ua.xaml", "lang.xaml" };
        bool dict = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ChangeLangButton_Click(object sender, RoutedEventArgs e)
        {
            ResourceDictionary newDictionary = new ResourceDictionary();
            newDictionary.Source = new Uri(uriArr[Convert.ToInt32(dict)], UriKind.Relative);
            Application.Current.Resources.MergedDictionaries[0] = newDictionary;
            dict = !dict;
        }
    }
}
