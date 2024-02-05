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
    /// Логика взаимодействия для TaskPage.xaml
    /// </summary>
    public partial class TaskPage : Page
    {
        public TaskPage()
        {
            InitializeComponent();

        }
        private void Refresh()
        {
            var filter = App.DB.Task.Where(x => x.DeportamentId == App.loginedUser.DeportamentId);
            string search = TBSearch.Text.ToLower();
            if (!string.IsNullOrWhiteSpace(search))
                filter = filter.Where(x => x.Requiement.ToLower().Contains(search));
            DGTasks.ItemsSource = filter.ToList();
        }

        private void TBSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            Refresh();
        }

        private void BAdd_Click(object sender, RoutedEventArgs e)
        {
            Task selected = DGTasks.SelectedItem as Task;
            if (selected == null)
            {
                MessageBox.Show("Вы ничего не выбрали");
                return;
            }
        }
    }
}
