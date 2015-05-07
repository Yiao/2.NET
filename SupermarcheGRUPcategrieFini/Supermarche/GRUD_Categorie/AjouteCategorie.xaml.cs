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

namespace Supermarche.GRUD_Categorie
{
    /// <summary>
    /// Logique d'interaction pour AjouteCategorie.xaml
    /// </summary>
    public partial class AjouteCategorie : MetroWindow
    {
        MarcketDBEntities database = new MarcketDBEntities();
        Sections tabSections = new Sections();
        public AjouteCategorie()
        {
            InitializeComponent();
        }

        private void AjouteCate(object sender, RoutedEventArgs e)
        {
            tabSections.Categorie = NomDeCategorie.Text;
            database.Sections.Add(tabSections);
            database.SaveChanges();
        }

        private void StatusManager(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
