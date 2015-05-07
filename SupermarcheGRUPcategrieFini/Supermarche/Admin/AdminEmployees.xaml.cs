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
using Supermarche.GRUD_Employees;

namespace Supermarche
{
    /// <summary>
    /// Logique d'interaction pour AdminEmployees.xaml
    /// </summary>
    public partial class AdminEmployees : UserControl
    {
        MarcketDBEntities database = new MarcketDBEntities();
        Employees tabEmployees = new Employees();

        public AdminEmployees()
        {
            InitializeComponent();
        }

        private void retoure_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new Admin();
        }

        private void DataGridMenu_Employees(object sender, RoutedEventArgs routedEventArgs)
        {
            var query = from a in database.Employees
                        select new { a.Id, a.FirstName, a.Name,a.Fonction};
            DataGridCategorie.ItemsSource = query.ToList();
        }

        private void Ajoute(object sender, RoutedEventArgs e)
        {
            AjouteEmployees objetAjouteEmployees = new AjouteEmployees();
            objetAjouteEmployees.Show();
        }

        private void Supprime(object sender, RoutedEventArgs e)
        {

        }

        private void Modifie(object sender, RoutedEventArgs e)
        {

        }

        private void Update(object sender, RoutedEventArgs e)
        {
            this.Content = new AdminEmployees();
        }
    }
}
