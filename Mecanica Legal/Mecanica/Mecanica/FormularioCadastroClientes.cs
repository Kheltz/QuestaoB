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
    public partial class FormularioCadastroClientes : Form
    {
        public FormularioCadastroClientes()
        {
            InitializeComponent();
        }

        private void butVoltarReg_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Index home = new Index();
            home.ShowDialog();
        }

        private void butSalvarReg_Click_1(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtDataNascimento.Text == "")
            {
                MessageBox.Show("Por favor, preencha todos os campos.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                Clientes c = new Clientes();
                c.SetNome(txtNome.Text);
                c.SetDataNascimento(txtDataNascimento.Text);
                c.Incluir();
                MessageBox.Show("Dados do veículo cadastrado com sucesso!",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.Hide();
                Index home = new Index();
                home.ShowDialog();
            }

        }
    }
}
