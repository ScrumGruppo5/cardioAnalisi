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
        public SchedaCliente(string nome)
        {
            InitializeComponent();
            lblNome.Content = nome;
        }
    }
}
