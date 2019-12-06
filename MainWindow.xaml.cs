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

namespace spesaWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var farina = int.Parse(txt_far.Text);
                var latte = int.Parse(txt_lat.Text);
                var risultato = 0;

                risultato = (2 * farina) + (5 * latte);
                lbl_ris.Content = $"Pagherai {risultato} euro.";
            }
            catch
            {
                MessageBox.Show("devi inserire dei numeri");
            }
        }
    }
}
