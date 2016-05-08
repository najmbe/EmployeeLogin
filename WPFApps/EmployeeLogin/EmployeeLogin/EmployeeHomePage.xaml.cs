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

namespace EmployeeLogin
{

    /// <summary>
    /// Interaction logic for EmployeeHomePage.xaml
    /// </summary>
    public partial class EmployeeHomePage : Window
    {
        public EmployeeViewModel vm = new EmployeeViewModel();
      
        public EmployeeHomePage()
        {
            InitializeComponent();
            DataContext = vm;
        }

        internal void SetEmployeeUserName(string value)
        {
            txtBlock.Text = "Welcome " + value;
        }
    }
}
