using cardioLibrary;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace DataCardio_WPF
{
    /// <summary>
    /// Interaction logic for SchedaCliente.xaml
    /// </summary>
    public partial class SchedaCliente : Window
    {
        public SchedaCliente(string nome,string cognome, string età, string peso, string durata, string distanza,string sesso, string allenamento)
        {
            InitializeComponent();
            lblNome.Content = nome;
            lblCognome.Content = cognome;
            lblEtà.Content = età;
            lblPeso.Content = peso;
            lblSesso.Content = sesso;
            lblEfficace.Content = DataCardio.FrequenzaConsigliata(int.Parse(età));
                
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window1 = new MainWindow();
            window1.Show();
            Close();
        }
    }
}
