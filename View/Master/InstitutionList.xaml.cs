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

namespace HRApp.View.Master
{
    /// <summary>
    /// Interaction logic for InstitutionList.xaml
    /// </summary>
    public partial class InstitutionList : Window
    {
        InstitutionRegister frmInstitutionRegister;

        public InstitutionList()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            if (frmInstitutionRegister == null)
            {
                frmInstitutionRegister = new InstitutionRegister();
            }

            if (frmInstitutionRegister.ShowDialog() == true)
            {

            }
        }
    }
}
