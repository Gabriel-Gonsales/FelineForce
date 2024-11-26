using FelineForce.Models;
using FelineForce.Services.Interfaces;
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
    public partial class frmCadastraAgendamento : Form
    {
        private readonly IAgendamentoService _agendamentoService;
        private Form form;
        private int tipo;
        public frmCadastraAgendamento(int Tipo, Form Form, IAgendamentoService agendamentoService)
        {
            InitializeComponent();
            tipo = Tipo;
            form = Form;
            _agendamentoService = agendamentoService;
        }
        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmCadastraAgendamento_Load(object sender, EventArgs e)
        {
            if (tipo == 1)
                lblAgendamento.Text += " Banho e Tosa";
            else if (tipo == 2)
            {
                lblAgendamento.Text += " Veterinario";
                cbxBanho.Visible = false;
                cbxTosa.Visible = false;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCadastraAgendamento_FormClosed(object sender, FormClosedEventArgs e)
        {
            (form as frmAgendamentos).OnChildFormClosed();
            form.Show();
        }

        private void lblAgendamento_Click(object sender, EventArgs e)
        {

        }

        private async void btnAgendar_Click(object sender, EventArgs e)
        {
            var dataAtendimento = dateTimePicker1.Value;
            var descricao = textBox1.Text;
            var nomeGato = txtNome.Text;
            var cpfTutor = txtTelefone.Text;

            if (string.IsNullOrWhiteSpace(nomeGato) || string.IsNullOrWhiteSpace(cpfTutor))
            {
                MessageBox.Show("Nome do gato e CPF do tutor são obrigatórios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Atendimento.TipoAtendimento tipoAtendimento;

            if (tipo == 1)
            {
                if (cbxBanho.Checked && cbxTosa.Checked)
                {
                    tipoAtendimento = Atendimento.TipoAtendimento.BanhoTosa;
                }
                else if (cbxBanho.Checked)
                {
                    tipoAtendimento = Atendimento.TipoAtendimento.Banho;
                }
                else if (cbxTosa.Checked)
                {
                    tipoAtendimento = Atendimento.TipoAtendimento.Tosa;
                }
                else
                {
                    MessageBox.Show("Selecione pelo menos um tipo de atendimento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else if (tipo == 2)
            {
                tipoAtendimento = Atendimento.TipoAtendimento.Vacina;
            }
            else
            {
                MessageBox.Show("Tipo de atendimento inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Busca o gato pelo nome e CPF do tutor
                var gato = await _agendamentoService.BuscarGatoPorNomeECPF(nomeGato, cpfTutor);
                if(gato == null)
                {
                    MessageBox.Show("Gato não encontrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Criação do objeto de agendamento
                var atendimento = new Atendimento
                {
                    Tipo = tipoAtendimento,
                    DataAtendimento = dataAtendimento,
                    Descricao = descricao,
                    Gato = gato,
                    Tutor = gato.Tutor // O Tutor já estará vinculado ao gato
                };

                // Salva o agendamento
                await _agendamentoService.CriarAtendimento(atendimento.Tipo, atendimento.DataAtendimento, descricao, gato);

                MessageBox.Show("Agendamento criado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Fecha o formulário
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao criar agendamento: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxTosa_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbxBanho_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
