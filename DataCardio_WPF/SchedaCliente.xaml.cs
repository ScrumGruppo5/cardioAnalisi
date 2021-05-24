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
        public SchedaCliente(string nome, string cognome, int età, double peso, double durata, double distanza, string sesso, string allenamento)
        {

            InitializeComponent();
            lblNome.Content = nome;
            lblCognome.Content = cognome;
            lblEtà.Content = età;
            lblPeso.Content = peso;
            lblSesso.Content = sesso;
            lblEfficace.Content = DataCardio.FrequenzaConsigliata(età) + "bpm";
            lblTipo.Content = DataCardio.FrequenzaCardiaca((int)DataCardio.MediaBattiti("dati.txt"));
            lblCalorieBruciate.Content = DataCardio.CalorieBruciate(sesso, età, peso, durata, DataCardio.MediaBattiti("dati.txt"));
            lblSpesaEnergetica.Content = DataCardio.SpesaEnergetica(allenamento, distanza, peso) + "KCal";
            lblBattitoMedio.Content = DataCardio.MediaBattiti("dati.txt") + "bpm";
            lblBattitoRiposo.Content = DataCardio.BattitiRiposo("dati.txt") + "bpm";
            lblVariabilità.Content = DataCardio.VariabilitàBattiti("dati.txt");
            lblSoglia.Content = DataCardio.SogliaAnaerobica(età);



        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window1 = new MainWindow();
            window1.Show();
            Close();
        }
    }
}
