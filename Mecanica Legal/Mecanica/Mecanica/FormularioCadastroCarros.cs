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
    public partial class FormularioCadastroCarros : Form
    {
        public FormularioCadastroCarros()
        {
            InitializeComponent();
        }

        private void FormularioCadastroCarros_Load(object sender, EventArgs e)
        {
            cboCorCarro.DataSource = Enum.GetNames(typeof(Carros.Cores));
        }

        private void butSalvarReg_Click(object sender, EventArgs e)
        {
            if (txtMarca.Text == "" || txtModelo.Text == "" || txtAno.Text == "" || txtPortas.Text == "")
            {
                MessageBox.Show("Por favor, preencha todos os campos.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                Carros v = new Carros();
                v.SetMarca(txtMarca.Text);
                v.SetModelo(txtModelo.Text);
                v.SetAno(int.Parse(txtAno.Text));
                v.SetCores((Carros.Cores)cboCorCarro.SelectedIndex);
                v.SetPortas(int.Parse(txtPortas.Text));
                v.Incluir();
                MessageBox.Show("Dados do veículo cadastrado com sucesso!",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.Hide();
                Index home = new Index();
                home.ShowDialog();
            }

        }

        private void butVoltarReg_Click(object sender, EventArgs e)
        {
            this.Hide();
            Index home = new Index();
            home.ShowDialog();
        }
    }
}
