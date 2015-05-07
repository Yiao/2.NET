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
using Supermarche.GRUD_Categorie;

namespace Supermarche
{
    /// <summary>
    /// Logique d'interaction pour Admin.xaml
    /// </summary>
    public partial class Admin : UserControl
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void retoure_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new Main();
        }

        private void Product_Copy_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Categories_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new AdminCategorie();
        }

        private void Employees_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new AdminEmployees();
        }
    }
}
