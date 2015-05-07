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
    /// Logique d'interaction pour ModiffieCategorie.xaml
    /// </summary>
    public partial class ModiffieCategorie : MetroWindow
    {
        MarcketDBEntities database = new MarcketDBEntities();
        Sections tabSections = new Sections();
        public ModiffieCategorie()
        {
            InitializeComponent();
        }

        private void modifier_categorie(object sender, RoutedEventArgs e)
        {
            int instant = Convert.ToInt32(IdCategorie.Text);

            var query = from a in database.Sections
                        where a.Id == instant
                        select a;

            var elementSelected = query.Single();
            elementSelected.Categorie = NomDeCategorie.Text;
            database.SaveChanges();
        }


    }
}
