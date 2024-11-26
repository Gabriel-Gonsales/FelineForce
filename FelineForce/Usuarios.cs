using FelineForce.Migrations;
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

namespace ERP_com_relatorio
{
    public partial class frmUsuarios : Form
    {
        Form form;
        string id;
        private readonly IUsuarioService _usuarioService;
        public frmUsuarios(Form Form, IUsuarioService usuarioService)
        {
            InitializeComponent();
            form = Form;
            _usuarioService = usuarioService;
            this.Load += frmUsuarios_Load;
        }
        private async void frmUsuarios_Load(object sender, EventArgs e)
        {
            try
            {
                grdUsuarios.Columns.Clear();
                // Carregar os usuários no DataGridView
                var usuarios = await _usuarioService.ObterTodosUsuarios(); // Substitua este método conforme necessário
                grdUsuarios.DataSource = usuarios; // Carrega a lista de usuários na grid
                grdUsuarios.Refresh(); // Atualiza a grid
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os usuários: " + ex.Message);
            }
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUsuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();
        }
        private async void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Selecione um usuário para excluir.");
                return;
            }

            var confirmResult = MessageBox.Show("Tem certeza que deseja excluir este usuário?", "Confirmação", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    if(Guid.TryParse(id, out Guid userId))
                    {
                        await _usuarioService.ExcluirUsuario(userId); // Substitua com o método correto de exclusão
                        MessageBox.Show("Usuário excluído com sucesso!");
                        frmUsuarios_Load(null, null); // Recarregar a lista de usuários
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir usuário: " + ex.Message);
                }
            }
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastraUsuario frmCadastraUsuario = new frmCadastraUsuario(this, _usuarioService);
            frmCadastraUsuario.Show();
            this.Hide();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmCadastraUsuario frmCadastraUsuario = new frmCadastraUsuario(this, id, _usuarioService);
            frmCadastraUsuario.Show();
            this.Hide();
        }

        private void grdUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se o usuário clicou em uma célula válida
            if (e.RowIndex >= 0)
            {
                // Pega o ID do usuário selecionado
                id = grdUsuarios.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                                                                               
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
            }
        }

        private async void btnExcluir_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Selecione um usuário para excluir.");
                return;
            }

            var confirmResult = MessageBox.Show("Tem certeza que deseja excluir este usuário?", "Confirmação", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    if (Guid.TryParse(id, out Guid userId))
                    { 
                        await _usuarioService.ExcluirUsuario(userId); // Substitua com o método correto de exclusão
                        MessageBox.Show("Usuário excluído com sucesso!");
                        frmUsuarios_Load(null, null); // Recarregar a lista de usuários
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir usuário: " + ex.Message);
                }
            }
        }
    }
}
