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

namespace KR2_Morozov.Pages
{
    /// <summary>
    /// Логика взаимодействия для GlavaPage.xaml
    /// </summary>
    public partial class GlavaPage : Page
    {
        public GlavaPage()
        {
            InitializeComponent();
        }

        private void BUserList_Click(object sender, RoutedEventArgs e)
        {
            GlavaFrame.Navigate(new UserListPage());
        }

        private void BtaskPage_Click(object sender, RoutedEventArgs e)
        {
            GlavaFrame.Navigate(new TaskPage());
        }
    }
}
