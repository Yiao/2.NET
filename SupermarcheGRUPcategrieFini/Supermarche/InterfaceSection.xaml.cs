using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace Supermarche
{
    /// <summary>
    /// Logique d'interaction pour InterfaceSection.xaml
    /// </summary>
    public partial class InterfaceSection : UserControl
    {
        public InterfaceSection()
        {
            InitializeComponent();
        }

        private void Retoure_Map(object sender, RoutedEventArgs e)
        {
            this.Content = new SupermarcheMapFenetre();
        }
    }
}
