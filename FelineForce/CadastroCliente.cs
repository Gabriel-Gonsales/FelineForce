using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_com_relatorio
{
    public partial class frmCadastroCliente : Form
    {
        private Form form;
        private string nome, cpf, telefone;
        public frmCadastroCliente(Form Form)
        {
            InitializeComponent();
            form = Form;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            nome = txtNome.Text;
            cpf = txtCPF.Text;
            telefone = txtTelefone.Text;
        }

        private void frmCadastroCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
