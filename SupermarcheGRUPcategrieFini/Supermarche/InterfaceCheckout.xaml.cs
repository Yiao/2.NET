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

namespace Supermarche
{
    /// <summary>
    /// Logique d'interaction pour InterfaceCheckout.xaml
    /// </summary>
    public partial class InterfaceCheckout : UserControl
    {
        public InterfaceCheckout()
        {
            InitializeComponent();
        }

        private void retoure_Click(object sender, RoutedEventArgs e)
        {
            this.Content =new SupermarcheMapFenetre();
        }

        private void Settings_click(object sender, RoutedEventArgs e)
        {
            this.Content = new Admin();
        }
    }
}
