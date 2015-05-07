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
using MahApps.Metro.Controls;

namespace Supermarche.GRUD_Employees
{
    /// <summary>
    /// Logique d'interaction pour AjouteEmployees.xaml
    /// </summary>
    
    public partial class AjouteEmployees : MetroWindow
    {
        MarcketDBEntities database = new MarcketDBEntities();
        Employees tabEmployees = new Employees();

        public AjouteEmployees()
        {
            InitializeComponent();
        }

        private void AjouteEmp(object sender, RoutedEventArgs e)
        {
            tabEmployees.FirstName = NomDeEmployee.Text;
            tabEmployees.Name = PrenomDeEmployee.Text;
            database.Employees.Add(tabEmployees);
            database.SaveChanges();
        }

        private void StatusManager(object sender, RoutedEventArgs e)
        {
            tabEmployees.Fonction = "Manager";
        }
    }
}
