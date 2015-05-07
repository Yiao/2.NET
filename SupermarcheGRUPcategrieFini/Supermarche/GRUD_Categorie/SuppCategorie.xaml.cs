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
    /// Logique d'interaction pour SuppCategorie.xaml
    /// </summary>
    public partial class SuppCategorie : MetroWindow
    {
        MarcketDBEntities database = new MarcketDBEntities();
        Sections tabSections = new Sections();
        public SuppCategorie()
        {
            InitializeComponent();
        }

        private void Supp(object sender, RoutedEventArgs e)
        {
            int instant = Convert.ToInt32(idCategorie.Text);

            var query = from a in database.Sections
                        where a.Id == instant
                        select a;

            foreach (var element in query)
            {
                database.Sections.Remove(element);
            }
            database.SaveChanges();
        }
    }
}
