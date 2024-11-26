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
    public partial class frmAreaAdm : Form
    {
        private readonly IVendaService _vendasService;
        private readonly IUsuarioService _usuarioService;
        private readonly ILogService _logService;
        private readonly IEstoqueService _estoqueService;
        public frmAreaAdm(IVendaService vendaService, IUsuarioService usuarioService, ILogService logService, IEstoqueService estoqueService)
        {
            InitializeComponent();
            _vendasService = vendaService;
            _usuarioService = usuarioService;
            _logService = logService;
            _estoqueService = estoqueService;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmAreaAdm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios frmUsuarios = new frmUsuarios(this, _usuarioService);
            frmUsuarios.Show();
            this.Hide();
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            frmRelatorios frmRelatorios = new frmRelatorios(this, _vendasService, _logService, _estoqueService);
            frmRelatorios.Show();
            this.Hide();
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            frmCompra frmCompra = new frmCompra(this, _estoqueService);
            frmCompra.Show();
            this.Hide();
        }
    }
}
