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
    /// Logique d'interaction pour AdminCategorie.xaml
    /// </summary>
    public partial class AdminCategorie : UserControl
    {
        MarcketDBEntities database = new MarcketDBEntities();
        Sections tabSections = new Sections();

        public AdminCategorie()
        {
            InitializeComponent();
        }

        private void retoure_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new Admin();
        }

        private void Ajoute(object sender, RoutedEventArgs e)
        {
            AjouteCategorie objetAjouteCategorie = new AjouteCategorie();
            objetAjouteCategorie.Show();
        }

        private void Modifie(object sender, RoutedEventArgs e)
        {
           ModiffieCategorie objetModiffieCategorie =new ModiffieCategorie();
           objetModiffieCategorie.Show();
        }

        private void Supprime(object sender, RoutedEventArgs e)
        {
            SuppCategorie objetSuppCategorie = new SuppCategorie();
            objetSuppCategorie.Show();
        }

        private void DataGridMenu_Categorie(object sender, RoutedEventArgs routedEventArgs)
        {
            var query = from a in database.Sections
                        select new { a.Id, a.Categorie };
            DataGridCategorie.ItemsSource = query.ToList();
        }

        private void Update(object sender, RoutedEventArgs e)
        {
            this.Content = new AdminCategorie();
        }
    }
}
