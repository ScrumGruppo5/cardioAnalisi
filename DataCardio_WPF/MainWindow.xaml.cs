using cardioLibrary;
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

        public MainWindow()
        {
            InitializeComponent();
            DataCardio.GeneraBattiti();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtNome.Text == "" || txtCognome.Text == "" || txtEtà.Text == "" || txtPeso.Text == "" || txtDistanza.Text == "" || txtDurata.Text == "")
            {
                MessageBox.Show("Compilare Tutti i Campi", "ATTENZIONE", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else
            {
                try
                {
                    int età = int.Parse(txtEtà.Text);
                    double peso = double.Parse(txtPeso.Text);
                    double durata = double.Parse(txtDurata.Text);
                    double distanza = double.Parse(txtDistanza.Text);
                    if (età > 0 && età < 120 && peso > 0 && peso < 200 && durata > 0 && distanza > 0)
                    {
                        string sesso, allenamento;
                        if (rdbMaschio.IsChecked == true)
                        {
                            sesso = "uomo";
                        }
                        else
                        {
                            sesso = "donna";
                        }
                        if (rdbCorsa.IsChecked == true)
                        {
                            allenamento = "Corsa";
                        }
                        else
                        {
                            allenamento = "Camminata";
                        }
                        SchedaCliente window2 = new SchedaCliente(txtNome.Text, txtCognome.Text, età, peso, durata, distanza, sesso, allenamento);
                        window2.Show();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show($"Dati Inseriti non Corretti", "ATTENZIONE", MessageBoxButton.OK, MessageBoxImage.Exclamation);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex}", "ATTENZIONE", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }

            }
        }

    }
}
