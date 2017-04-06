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
    public partial class FormularioCadastroMotos : Form
    {
        public FormularioCadastroMotos()
        {
            InitializeComponent();
        }

        private void FormularioCadastroMotos_Load(object sender, EventArgs e)
        {
            cboCorMoto.DataSource = Enum.GetNames(typeof(Motos.Cores));
        }

        private void butSalvarReg_Click(object sender, EventArgs e)
        {
            if (txtMarca.Text == "" || txtModelo.Text == "" || txtAno.Text == "" || txtCilindrada.Text == "")
            {
                MessageBox.Show("Por favor, preencha todos os campos.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                Motos m = new Motos();
                m.SetMarca(txtMarca.Text);
                m.SetModelo(txtModelo.Text);
                m.SetAno(int.Parse(txtAno.Text));
                m.SetCores((Motos.Cores)cboCorMoto.SelectedIndex);
                m.SetCilindrada(int.Parse(txtCilindrada.Text));
                m.Incluir();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
