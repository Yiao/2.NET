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

namespace Supermarche
{
    /// <summary>
    /// Logique d'interaction pour SupermarcheMapFenetre.xaml
    /// </summary>
    public partial class SupermarcheMapFenetre : UserControl
    {
        public SupermarcheMapFenetre()
        {
            InitializeComponent();
        }

        private void Section1_click(object sender, RoutedEventArgs e)
        {
            this.Content = new InterfaceSection();
        }

        private void retoure_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new Main();
        }

        private void Checkout_click(object sender, RoutedEventArgs e)
        {
            this.Content = new InterfaceCheckout();
        }
    }
}