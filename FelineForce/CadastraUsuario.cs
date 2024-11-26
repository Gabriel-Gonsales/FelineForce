using FelineForce.Models;
using FelineForce.Repository.Interfaces;
using FelineForce.Services;
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
    public partial class frmCadastraUsuario : Form
    {
        Form form;
        string id;
        private readonly IUsuarioService _usuarioService;
        public frmCadastraUsuario(Form Form, IUsuarioService usuarioService)
        {
            InitializeComponent();
            form = Form;
            _usuarioService = usuarioService;
        }
        public frmCadastraUsuario(Form Form, string Id, IUsuarioService usuarioService)
        {
            InitializeComponent();
            form = Form;
            id = Id;
            _usuarioService = usuarioService;
        }

        private void frmCadastraUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                var a = Enum.GetValues(typeof(Usuario.TipoUsuario))
                                               .Cast<Usuario.TipoUsuario>()
                                               .ToList();
                // Preenche o ComboBox com os valores do enum
                selecioneTipo.DataSource = Enum.GetValues(typeof(Usuario.TipoUsuario))
                                               .Cast<Usuario.TipoUsuario>()
                                               .ToList();

                // Verifica se é uma edição e carrega os dados
                if (!string.IsNullOrEmpty(id))
                {
                    CarregarDadosUsuario(id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar os dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void CarregarDadosUsuario(string id)
        {
            try
            {
                var usuario = await _usuarioService.ObterUsuarioPorId(Guid.Parse(id));
                if (usuario != null)
                {
                    txtNome.Text = usuario.Nome;
                    txtHoras.Text = usuario.HorasTrabalhadas.ToString();
                    txtSalario.Text = usuario.Salario.ToString();
                    selecioneTipo.SelectedItem = usuario.Tipo;
                }
                else
                {
                    MessageBox.Show("Usuário não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar usuário: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtHoras_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCadastraUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();
        }

        private void selecioneTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                // Valida os campos obrigatórios
                if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtHoras.Text) || string.IsNullOrWhiteSpace(txtSalario.Text))
                {
                    MessageBox.Show("Os campos Nome, Salário e Horas são obrigatórios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (selecioneTipo.SelectedItem == null)
                {
                    MessageBox.Show("Selecione um tipo de usuário.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Cria ou atualiza o usuário
                var tipoUsuario = (Usuario.TipoUsuario)selecioneTipo.SelectedItem;
                var senhaPadrao = "123456";

                if (string.IsNullOrEmpty(id))
                {
                    // Criação de um novo usuário
                    if (int.TryParse(txtHoras.Text.ToString(), out int horas) && decimal.TryParse(txtSalario.Text.ToString(), out decimal salario) && horas > 0)
                    {
                        await _usuarioService.CriarUsuario(txtNome.Text, salario, horas, senhaPadrao, tipoUsuario);
                    }
                    MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Atualização de um usuário existente
                    var usuario = await _usuarioService.ObterUsuarioPorId(Guid.Parse(id));
                    if (usuario != null)
                    {
                        usuario.Nome = txtNome.Text;
                        usuario.Tipo = tipoUsuario;
                        if (int.TryParse(txtHoras.Text.ToString(), out int horas) && decimal.TryParse(txtSalario.Text.ToString(), out decimal salario) && horas > 0)
                        {
                            usuario.HorasTrabalhadas = horas;
                            usuario.Salario = salario;
                        }
                        await _usuarioService.AtualizarUsuario(usuario);
                        MessageBox.Show("Usuário atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Usuário não encontrado para atualizar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar usuário: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnResetarSenha_Click(object sender, EventArgs e)
        {

        }

        private void selecioneTipo_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
