using FelineForce.Models;
using FelineForce;
using FelineForce.Services;
using FelineForce.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ERP_com_relatorio
{
    public partial class frmLogin : Form
    {
        private readonly IServiceProvider _serviceProvider;
        public frmLogin(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
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
        private async void btnLogar_Click(object sender, EventArgs e)
        {
            try
            {
                using var scope = _serviceProvider.CreateScope();
                var autenticacaoService = scope.ServiceProvider.GetRequiredService<IAutenticacaoService>();

                // Coleta os dados do formulário
                string nome = txtLogin.Text.Trim();
                string senha = txtSenha.Text.Trim();

                // Realiza o login
                var usuario = await autenticacaoService.LoginAsync(nome, senha);

                if (usuario == null)
                {
                    MessageBox.Show("Usuário ou senha incorretos, ou o usuário está bloqueado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Armazena o usuário na sessão global
                Sessao.Logar(usuario);

                // Redireciona para a área correta baseado no tipo de usuário
                if (usuario.Tipo == Usuario.TipoUsuario.Administrador)
                {
                    var vendaService = scope.ServiceProvider.GetRequiredService<IVendaService>();
                    var usuarioService = scope.ServiceProvider.GetRequiredService<IUsuarioService>();
                    var logService = scope.ServiceProvider.GetRequiredService<ILogService>();
                    var estoqueService = scope.ServiceProvider.GetRequiredService<IEstoqueService>();
                    var frmAreaAdm = new frmAreaAdm(vendaService, usuarioService, logService, estoqueService);
                    frmAreaAdm.Show();
                }
                else
                {
                    var clienteService = scope.ServiceProvider.GetRequiredService<IClienteService>();
                    var estoqueService = scope.ServiceProvider.GetRequiredService<IEstoqueService>();
                    var gatoService = scope.ServiceProvider.GetRequiredService<IGatoService>();
                    var agendamentosService = scope.ServiceProvider.GetRequiredService<IAgendamentoService>();
                    var vendaService = scope.ServiceProvider.GetRequiredService<IVendaService>();
                    var frmAreaComum = new frmAreaComum(clienteService, estoqueService, gatoService, agendamentosService, vendaService);
                    frmAreaComum.Show();
                }

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar login: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
