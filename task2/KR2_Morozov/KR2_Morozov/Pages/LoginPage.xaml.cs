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
using KR2_Morozov.Model;

namespace KR2_Morozov.Pages
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void BLogin_Click(object sender, RoutedEventArgs e)
        {
            string fio = TBLogin.Text;
            string password = TBPassword.Text;
            var LoggedUser = App.DB.User.FirstOrDefault(x => x.FIO == fio && x.Password == password);
            if (LoggedUser == null)
            {
                MessageBox.Show("wrong login password");
                return;
            }
            App.loginedUser = LoggedUser;
            if (LoggedUser.RoleId == 1)
            {
                NavigationService.Navigate(new GlavaPage());
            }
            if (LoggedUser.RoleId == 2)
            {
                NavigationService.Navigate(new ProgammerPage());
            }

        }
    }
}
