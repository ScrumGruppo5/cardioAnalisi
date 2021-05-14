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

namespace DataCardio_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        string nome;
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtNome.Text == "" || txtCognome.Text == "")
            {
                MessageBox.Show("Compilare Tutti i Campi", "ATTENZIONE", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else
            {
                SchedaCliente window2 = new SchedaCliente(txtNome.Text);
                window2.Show();
                Close();
                nome = txtNome.Text;
                
            }
        }
        
    }
}
