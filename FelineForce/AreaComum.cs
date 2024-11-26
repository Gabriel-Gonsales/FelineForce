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

namespace ERP_com_relatorio
{
    public partial class frmAreaComum : Form
    {
        private readonly IClienteService _clienteService;
        private readonly IEstoqueService _estoqueService;
        private readonly IGatoService _gatoService;
        private readonly IAgendamentoService _agendamentosService;
        private readonly IVendaService _vendaService;

        public frmAreaComum(IClienteService clienteService, IEstoqueService estoqueService, IGatoService gatoService, IAgendamentoService agendamentosService, IVendaService vendaService)
        {
            _clienteService = clienteService;
            _estoqueService = estoqueService;
            _gatoService = gatoService;
            InitializeComponent();
            _agendamentosService = agendamentosService;
            _vendaService = vendaService;
        }

        private void AreaComum_Load(object sender, EventArgs e)
        {

        }
        private void btnVeterinario_Click(object sender, EventArgs e)
        {
            frmAgendamentos frmAgendamentos = new frmAgendamentos(2, this, _agendamentosService);
            frmAgendamentos.Show();
            this.Hide();
        }
        private void frmAreaComum_FormClosed(object sender, FormClosedEventArgs e)
        {
           Application.Exit();
        }
        private void btnBanho_Click(object sender, EventArgs e)
        {
            frmAgendamentos frmAgendamentos = new frmAgendamentos(1, this, _agendamentosService);
            frmAgendamentos.Show();
            this.Hide();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Sessao.Logout();
            Application.Exit();
        }
        private void btnVenda_Click(object sender, EventArgs e)
        {
            frmVenda frmVenda = new frmVenda(this, _vendaService, _estoqueService);
            frmVenda.Show();
            this.Hide();
        }
        private void btnEstoque_Click(object sender, EventArgs e)
        {
            frmEstoque frmEstoque = new frmEstoque(this, _estoqueService);
            frmEstoque.Show();
            this.Hide();
        }
        private void btnClientes_Click(object sender, EventArgs e)
        {
            // Cria e exibe o formulário de cadastro de clientes
            frmClientes frmClientes = new frmClientes(this, _clienteService);
            frmClientes.Show();
            this.Hide();
        }
        private void btnGatos_Click(object sender, EventArgs e)
        {
            frmGatos frmGatos = new frmGatos(this, _gatoService);
            frmGatos.Show();
            this.Hide();
        }

        private void btnAvaliacao_Click(object sender, EventArgs e)
        {

        }
    }
}
