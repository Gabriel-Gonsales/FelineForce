using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ERP_com_relatorio
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtLogin.Text = "Usuário";
            txtSenha.Text = "Senha";
            txtSenha.UseSystemPasswordChar = false;
            txtLogin.GotFocus += RemovePlaceholderUser;
            txtLogin.LostFocus += SetPlaceholderUser;
            txtSenha.GotFocus += RemovePlaceholderSenha;
            txtSenha.LostFocus += SetPlaceholderSenha;
            btnLogar.FlatAppearance.BorderSize = 0;
            btnAdmin.FlatAppearance.BorderSize = 0;
        }

        private void RemovePlaceholderUser(object sender, EventArgs e)
        {
            if (txtLogin.Text == "Usuário")
            {
                txtLogin.Text = "";
                txtLogin.ForeColor = Color.Black;
            }
        }

        private void SetPlaceholderUser(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLogin.Text))
            {
                txtLogin.Text = "Usuário";
                txtLogin.ForeColor = Color.FromArgb(200, 62, 77);
            }
        }

        private void RemovePlaceholderSenha(object sender, EventArgs e)
        {
            if (txtSenha.Text == "Senha" && txtSenha.UseSystemPasswordChar == false)
            {
                txtSenha.Text = "";
                txtSenha.ForeColor = Color.Black;
            }
        }

        private void SetPlaceholderSenha(object sender, EventArgs e)
        {
            if (txtSenha.Text == "")
            {
                txtSenha.Text = "Senha";
                txtSenha.ForeColor = Color.FromArgb(200, 62, 77);
                txtSenha.UseSystemPasswordChar = false;
            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            if (txtSenha.Text != "")
                txtSenha.UseSystemPasswordChar = true;
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            frmAreaComum frmAreaComum = new frmAreaComum();
            frmAreaComum.Show();
            this.Hide();
        }

    }
}
