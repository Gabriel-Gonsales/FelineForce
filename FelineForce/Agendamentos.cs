using FelineForce.Migrations;
using FelineForce.Models;
using FelineForce.Services;
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
    public partial class frmAgendamentos : Form
    {
        private int tipo;
        private Form form;
        private readonly IAgendamentoService _agendamentoService;
        public frmAgendamentos(int Tipo, Form Form, IAgendamentoService agendamentoService)
        {
            InitializeComponent();
            tipo = Tipo;
            form = Form;
            _agendamentoService = agendamentoService;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private async void frmAgendamentos_Load(object sender, EventArgs e)
        {
            IEnumerable<Atendimento> agendamentos = [];
            if (tipo == 1)
            {
                lblAgendamento.Text += " Banho e Tosa";
                var banhos = await _agendamentoService.BuscarAtendimentosAsync(0);
                var tosa = banhos.Union<Atendimento>(await _agendamentoService.BuscarAtendimentosAsync(1));
                agendamentos = tosa.Union<Atendimento>(await _agendamentoService.BuscarAtendimentosAsync(2));
            }
            else if (tipo == 2)
            {
                agendamentos = await _agendamentoService.BuscarAtendimentosAsync(3);
                lblAgendamento.Text += " Veterinario";
            }
            // Limpa as colunas existentes
            grdAgendamentos.Columns.Clear();

            // Adiciona as colunas manualmente (caso queira personalizar)
            grdAgendamentos.Columns.Add("Id", "Id");
            grdAgendamentos.Columns.Add("DataHora", "Data e Hora");
            grdAgendamentos.Columns.Add("Gato", "Gato");
            grdAgendamentos.Columns.Add("Agendamento", "Agendamento");

            // Preenche o DataGridView com os dados de clientes
            foreach (var agendamento in agendamentos)
            {
                grdAgendamentos.Rows.Add(agendamento.Id, agendamento.DataAtendimento, agendamento.Gato.Nome, agendamento.Tipo.ToString());
            }
        }
        public async void OnChildFormClosed()
        {
            IEnumerable<Atendimento> agendamentos = [];
            if (tipo == 1)
            {
                lblAgendamento.Text += " Banho e Tosa";
                var banhos = await _agendamentoService.BuscarAtendimentosAsync(0);
                var tosa = banhos.Union<Atendimento>(await _agendamentoService.BuscarAtendimentosAsync(1));
                agendamentos = tosa.Union<Atendimento>(await _agendamentoService.BuscarAtendimentosAsync(2));
            }
            else if (tipo == 2)
            {
                agendamentos = await _agendamentoService.BuscarAtendimentosAsync(3);
                lblAgendamento.Text += " Veterinario";
            }
            // Limpa as colunas existentes
            grdAgendamentos.Columns.Clear();

            // Adiciona as colunas manualmente (caso queira personalizar)
            grdAgendamentos.Columns.Add("Id", "Id");
            grdAgendamentos.Columns.Add("DataHora", "Data e Hora");
            grdAgendamentos.Columns.Add("Gato", "Gato");
            grdAgendamentos.Columns.Add("Agendamento", "Agendamento");

            // Preenche o DataGridView com os dados de clientes
            foreach (var agendamento in agendamentos)
            {
                grdAgendamentos.Rows.Add(agendamento.Id, agendamento.DataAtendimento, agendamento.Gato.Nome, agendamento.Tipo.ToString());
            }
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAgendamentos_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            frmCadastraAgendamento frmCadastraAgendamento = new frmCadastraAgendamento(tipo, this, _agendamentoService);
            frmCadastraAgendamento.Show();
            this.Hide();
        }

        private void grdAgendamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
