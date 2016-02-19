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
using HRApp.View.Employee;

namespace HRApp
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {

        EmployeeEducation frmEducationRegister;

        public Menu()
        {
            InitializeComponent();
        }

        private void mstrEducation_Click(object sender, RoutedEventArgs e)
        {
            if (frmEducationRegister == null)
            {
                frmEducationRegister = new EmployeeEducation();
            }

            if (frmEducationRegister.ShowDialog() == true)
            {

            }
        }

        private void mstrInstitution_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
