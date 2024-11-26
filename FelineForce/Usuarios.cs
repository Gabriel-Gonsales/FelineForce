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
            grdUsuarios.CellFormatting += grdUsuarios_CellFormatting;
        }
        private async void frmUsuarios_Load(object sender, EventArgs e)
        {
            try
            {
                grdUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                // Carregar os usuários no DataGridView
                var usuarios = await _usuarioService.ObterTodosUsuarios();
                grdUsuarios.DataSource = usuarios; // Carrega a lista de usuários na grid
                // Configura as colunas para exibir apenas as desejadas
                grdUsuarios.AutoGenerateColumns = false;
                grdUsuarios.Columns.Clear(); // Limpa as colunas anteriores

                // Adicionar colunas específicas
                grdUsuarios.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "Id",
                    DataPropertyName = "Id",
                    Name = "Id",
                    ReadOnly = true
                });
                grdUsuarios.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "Nome",
                    DataPropertyName = "Nome",
                    Name = "Nome"
                });
                grdUsuarios.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "Horas Trabalhadas",
                    DataPropertyName = "HorasTrabalhadas",
                    Name = "HorasTrabalhadas"
                });
                grdUsuarios.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "Salário",
                    DataPropertyName = "Salario",
                    Name = "Salario"
                });
                grdUsuarios.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "Tipo",
                    DataPropertyName = "Tipo",
                    Name = "Tipo"
                });
                grdUsuarios.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "Inclusão",
                    DataPropertyName = "Inclusao",
                    Name = "Inclusao",
                    ReadOnly = true
                });

                grdUsuarios.Refresh(); // Atualiza a grid
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os usuários: " + ex.Message);
            }
        }
        private void grdUsuarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Verifica se a célula pertence à coluna Salário
            if (grdUsuarios.Columns[e.ColumnIndex].Name == "Salario" && e.Value != null)
            {
                // Formata o valor como moeda com 2 casas decimais
                if (decimal.TryParse(e.Value.ToString(), out decimal salario))
                {
                    e.Value = salario.ToString("F2"); // Formato com 2 casas decimais
                    e.FormattingApplied = true;
                }
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
