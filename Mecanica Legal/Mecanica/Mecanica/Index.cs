using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mecanica
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void butCadCarro_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormularioCadastroCarros carros = new FormularioCadastroCarros();
            carros.ShowDialog();
        }

        private void butCadMoto_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormularioCadastroMotos motos = new FormularioCadastroMotos();
            motos.ShowDialog();
        }

        private void butCadCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormularioCadastroClientes clientes = new FormularioCadastroClientes();
            clientes.ShowDialog();
        }

        private void butSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
