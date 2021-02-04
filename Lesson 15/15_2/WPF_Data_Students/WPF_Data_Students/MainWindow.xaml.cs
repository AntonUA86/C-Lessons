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
using WPF_Data_Students.ViewModel;

namespace WPF_Data_Students
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new StudentViewModel();
        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            ((StudentViewModel)DataContext).AddStudent();
        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            ((StudentViewModel)DataContext).DeleteStudent();
        }
    

    }
}
