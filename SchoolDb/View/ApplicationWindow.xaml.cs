using Microsoft.Azure.Documents;
using SchoolDb.ViewModel;
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
using System.Windows.Shapes;

namespace SchoolDb.View
{
    /// <summary>
    /// Логика взаимодействия для ApplicationWindow.xaml
    /// </summary>
    public partial class ApplicationWindow : Window
    {
        private DbEntity.User user;

        public ApplicationWindow(User user)
        {
            InitializeComponent();

            DataContext = new AppVM(user);
        }

        public ApplicationWindow(DbEntity.User user)
        {
            this.user = user;
        }
    }
}
