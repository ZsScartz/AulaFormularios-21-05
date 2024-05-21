using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Salas : Form
    {
        public Salas()
        {
            InitializeComponent();
        }

        private void Salas_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtComplemento.Text = "";
            txtNome.Text = "";
            txtNumCadeiras.Text = "";
            txtNumPC.Text = "";
            txtPredio.Text = "";
            chkLab.Checked = false;
            MessageBox.Show("O formulário foi limpo com sucesso", "Mensagem");
        }
    }
}
