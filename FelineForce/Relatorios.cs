using FelineForce.Migrations;
using FelineForce.Models;
using FelineForce.Services;
using FelineForce.Services.Interfaces;
using System.Data;
using System.Globalization;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;

namespace ERP_com_relatorio
{
    public partial class frmRelatorios : Form
    {
        Form form;
        private readonly IVendaService _vendaService;
        private readonly ILogService _logService;
        private readonly IEstoqueService _estoqueService;
        public frmRelatorios(Form form, IVendaService vendaService, ILogService logService, IEstoqueService estoqueService)
        {
            this.form = form;
            _vendaService = vendaService;
            _logService = logService;
            _estoqueService = estoqueService;
            InitializeComponent();
        }

        private void frmRelatorios_Load(object sender, EventArgs e)
        {
            grdRelatorios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dteInicio.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dteFim.Value = DateTime.Now;
            cmbFiltro.Items.Clear();
            cmbFiltro.Items.Add("Relatório de Lucratividade");
            cmbFiltro.Items.Add("Relatório de Compras");
            cmbFiltro.Items.Add("Relatório de Vendas");
            cmbFiltro.Items.Add("Relatório de Produtos");
            cmbFiltro.Items.Add("Relatório de Logs");
            cmbFiltro.SelectedIndex = 0; // Define um relatório padrão.
            AtualizarColunasRelatorio();
        }
        private async Task GerarRelatorioLogs()
        {
            // Obter o intervalo de datas
            DateTime dataInicio = dteInicio.Value.Date;
            DateTime dataFim = dteFim.Value.Date.AddDays(1).AddSeconds(-1);

            // Carregar os logs (Substitua pelo seu método real de obtenção de logs)
            var logs = await _logService.BuscarTodosLogs();

            // Filtrar logs pelo intervalo de datas
            var logsFiltrados = logs
                .Where(l => l.Inclusao >= dataInicio && l.Inclusao <= dataFim)
                .Select(l => new
                {
                    DataLog = l.Inclusao,
                    TipoLog = l.Tipo.ToString(),
                    Mensagem = l.Mensagem,
                    Usuario = l.Usuario.Nome ?? "Desconhecido"
                })
                .ToList();

            // Preencher o DataGridView com os logs
            grdRelatorios.Rows.Clear();
            foreach (var log in logsFiltrados)
            {
                grdRelatorios.Rows.Add(log.DataLog, log.TipoLog, log.Mensagem, log.Usuario);
            }

            if (!logsFiltrados.Any())
            {
                MessageBox.Show("Nenhum log encontrado no período selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private async Task GerarRelatorioLucratividade()
        {
            // Obtém o intervalo de datas
            DateTime dataInicio = dteInicio.Value.Date;
            DateTime dataFim = dteFim.Value.Date.AddDays(1).AddSeconds(-1);

            // Obtém vendas e compras no período
            var vendas = await _vendaService.ObterTodosVendas();
            var compras = await _estoqueService.ConsultarCompras(); // Supondo um método equivalente para compras.

            // Filtra vendas e compras pelo intervalo
            var vendasFiltradas = vendas.Where(v => v.Inclusao >= dataInicio && v.Inclusao <= dataFim).ToList();
            var comprasFiltradas = compras.Where(c => c.Inclusao >= dataInicio && c.Inclusao <= dataFim).ToList();

            // Calcula o custo total de compras por produto
            var custosPorProduto = comprasFiltradas
                .GroupBy(c => c.Nome)
                .ToDictionary(
                    g => g.Key,
                    g => g.Sum(c => (decimal)c.Preco) // Custo total = quantidade * custo unitário
                );

            // Calcula os dados de vendas e lucro por produto
            var relatorio = vendasFiltradas
                .SelectMany(v => v.Itens)
                .GroupBy(i => i.Nome)
                .Select(g => new
                {
                    Produto = g.Key,
                    QuantidadeVendida = g.Sum(i => i.Quantidade),
                    CustoTotal = custosPorProduto.ContainsKey(g.Key) ? custosPorProduto[g.Key] : 0,
                    ReceitaTotal = g.Sum(i => i.Total),
                    Lucro = g.Sum(i => i.Total) - (custosPorProduto.ContainsKey(g.Key) ? custosPorProduto[g.Key] : 0)
                })
                .OrderByDescending(r => r.Lucro)
                .ToList();

            // Exibe os dados no DataGridView
            grdRelatorios.Rows.Clear();
            foreach (var item in relatorio)
            {
                grdRelatorios.Rows.Add(item.Produto, item.QuantidadeVendida, item.CustoTotal.ToString("C"), item.ReceitaTotal.ToString("C"), item.Lucro.ToString("C"));
            }

            if (!relatorio.Any())
            {
                MessageBox.Show("Nenhuma informação encontrada no período selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void AtualizarColunasRelatorio()
        {
            grdRelatorios.Columns.Clear();
            if (cmbFiltro.SelectedItem.ToString() == "Relatório de Lucratividade")
            {
                grdRelatorios.Columns.Add("Produto", "Produto");
                grdRelatorios.Columns.Add("QuantidadeVendida", "Quantidade Vendida");
                grdRelatorios.Columns.Add("CustoTotal", "Custo Total (R$)");
                grdRelatorios.Columns.Add("ReceitaTotal", "Receita Total (R$)");
                grdRelatorios.Columns.Add("Lucro", "Lucro (R$)");
            }

            else if (cmbFiltro.SelectedItem.ToString() == "Relatório de Vendas")
            {
                grdRelatorios.Columns.Add("DataVenda", "Data da Venda");
                grdRelatorios.Columns.Add("CPFCliente", "CPF do Cliente");
                grdRelatorios.Columns.Add("TotalCompra", "Total da Compra");
                grdRelatorios.Columns.Add("QuantidadeItens", "Quantidade de Itens");
                grdRelatorios.Columns.Add("Itens", "Itens da Venda");
            }
            else if (cmbFiltro.SelectedItem.ToString() == "Relatório de Produtos")
            {
                grdRelatorios.Columns.Add("NomeProduto", "Produto");
                grdRelatorios.Columns.Add("QuantidadeVendida", "Quantidade Vendida");
                grdRelatorios.Columns.Add("TotalReceita", "Receita Total");
            }
            else if (cmbFiltro.SelectedItem.ToString() == "Relatório de Logs")
            {
                grdRelatorios.Columns.Add("DataLog", "Data do Log");
                grdRelatorios.Columns.Add("TipoLog", "Tipo de Log");
                grdRelatorios.Columns.Add("Mensagem", "Mensagem");
                grdRelatorios.Columns.Add("CriadoPor", "Criado Por");
            }
            else if (cmbFiltro.SelectedItem.ToString() == "Relatório de Compras")
            {
                grdRelatorios.Columns.Add("DataCompra", "Data da Compra");
                grdRelatorios.Columns.Add("Quantidade", "Quantidade");
                grdRelatorios.Columns.Add("Produto", "Produto");
                grdRelatorios.Columns.Add("TotalGasto", "Total Gasto");
                grdRelatorios.Columns.Add("Fornecedor", "Fornecedor");
            }
        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarColunasRelatorio();
            grdRelatorios.Rows.Clear(); // Limpa os dados ao mudar o tipo de relatório.
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRelatorios_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();
        }

        private void dteInicio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dteFim_ValueChanged(object sender, EventArgs e)
        {

        }
        //comentario teste
        private async void btnGerar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbFiltro.SelectedItem.ToString() == "Relatório de Compras")
                {
                    await GerarRelatorioCompras();
                }
                else if (cmbFiltro.SelectedItem.ToString() == "Relatório de Lucratividade")
                {
                    await GerarRelatorioLucratividade();
                }

                else if (cmbFiltro.SelectedItem.ToString() == "Relatório de Vendas")
                {
                    DateTime dataInicio = dteInicio.Value.Date;
                    DateTime dataFim = dteFim.Value.Date.AddDays(1).AddSeconds(-1);

                    var vendas = await _vendaService.ObterTodosVendas();
                    var vendasFiltradas = vendas
                        .Where(v => v.Inclusao >= dataInicio && v.Inclusao <= dataFim)
                        .Select(v => new
                        {
                            DataVenda = v.Inclusao,
                            CPFCliente = v.CPFCliente ?? "Não informado",
                            TotalCompra = v.TotalCompra.ToString("C"),
                            QuantidadeItens = v.Itens.Sum(item => item.Quantidade),
                            Itens = string.Join("; ", v.Itens.Select(i => $"{i.Quantidade}x {i.Nome}")) // Exibe os itens no formato "Quantidade x Nome".
                        })
                        .ToList();

                    grdRelatorios.Rows.Clear();
                    foreach (var venda in vendasFiltradas)
                    {
                        grdRelatorios.Rows.Add(venda.DataVenda, venda.CPFCliente, venda.TotalCompra, venda.QuantidadeItens, venda.Itens);
                    }

                    if (!vendasFiltradas.Any())
                    {
                        MessageBox.Show("Nenhuma venda encontrada no período selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (cmbFiltro.SelectedItem.ToString() == "Relatório de Produtos")
                {
                    await GerarRelatorioProdutos();
                }
                else if (cmbFiltro.SelectedItem.ToString() == "Relatório de Logs")
                {
                    await GerarRelatorioLogs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gerar relatório: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CriarGraficoFaturamento(List<FaturamentoMensal> faturamentoMensal, string caminhoArquivo)
        {
            var chart = new Chart
            {
                Width = 800,
                Height = 600
            };

            // Configurações do gráfico
            var chartArea = new ChartArea();
            chart.ChartAreas.Add(chartArea);

            var serie = new Series
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true
            };

            // Adiciona os dados à série
            foreach (var mes in faturamentoMensal)
            {
                string nomeMes = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(mes.Mes);
                serie.Points.AddXY(nomeMes, (double)mes.TotalFaturado);
            }

            chart.Series.Add(serie);

            // Salva o gráfico como imagem
            chart.SaveImage(caminhoArquivo, ChartImageFormat.Png);
            MessageBox.Show($"Gráfico salvo em: {caminhoArquivo}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private async Task GerarRelatorioProdutos()
        {
            var vendas = await _vendaService.ObterTodosVendas();

            // Agrupa os produtos vendidos
            var produtos = vendas
                .SelectMany(v => v.Itens)
                .GroupBy(i => i.Nome)
                .Select(g => new
                {
                    NomeProduto = g.Key,
                    QuantidadeVendida = g.Sum(i => i.Quantidade),
                    TotalReceita = g.Sum(i => i.Quantidade * i.Total) // Substitua `Total` pelo preço unitário se necessário.
                })
                .OrderByDescending(p => p.QuantidadeVendida)
                .ToList();

            grdRelatorios.Rows.Clear();
            foreach (var produto in produtos)
            {
                grdRelatorios.Rows.Add(produto.NomeProduto, produto.QuantidadeVendida, produto.TotalReceita.ToString("C"));
            }

            if (!produtos.Any())
            {
                MessageBox.Show("Nenhum produto encontrado no período selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private async Task GerarRelatorioCompras()
        {
            // Obter o intervalo de datas
            DateTime dataInicio = dteInicio.Value.Date;
            DateTime dataFim = dteFim.Value.Date.AddDays(1).AddSeconds(-1);

            // Obter todas as compras do serviço
            var compras = await _estoqueService.ConsultarCompras();

            // Filtrar as compras pelo intervalo de datas
            var comprasFiltradas = compras
                .Where(c => c.Inclusao >= dataInicio && c.Inclusao <= dataFim)
                .Select(c => new
                {
                    DataCompra = c.Inclusao,
                    Produto = c.Nome,
                    Quantidade = c.Quantidade,
                    TotalGasto = c.Preco,
                    Fornecedor = c.Fornecedor
                })
                .ToList();

            // Preencher o DataGridView com as compras filtradas
            grdRelatorios.Rows.Clear();
            foreach (var compra in comprasFiltradas)
            {
                grdRelatorios.Rows.Add(compra.DataCompra,compra.Produto, compra.Quantidade, compra.TotalGasto, compra.Fornecedor);
            }

            if (!comprasFiltradas.Any())
            {
                MessageBox.Show("Nenhuma compra encontrada no período selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void grdRelatorios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private async Task<IEnumerable<dynamic>> ObterProdutosFiltrados()
        {
            var vendas = await _vendaService.ObterTodosVendas();

            return vendas
                .SelectMany(v => v.Itens)
                .GroupBy(i => i.Nome)
                .Select(g => new
                {
                    NomeProduto = g.Key,
                    QuantidadeVendida = g.Sum(i => i.Quantidade),
                    TotalReceita = g.Sum(i => i.Quantidade * i.Total)
                })
                .OrderByDescending(p => p.QuantidadeVendida)
                .ToList();
        }

        private void CriarGraficoProdutos(IEnumerable<dynamic> produtos, string caminhoArquivo, string titulo, string eixoX, string eixoY, Func<dynamic, double> valorY)
        {
            var chart = new Chart
            {
                Width = 800,
                Height = 600
            };

            // Configurações do gráfico
            var chartArea = new ChartArea();
            chart.ChartAreas.Add(chartArea);

            var serie = new Series
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true
            };

            // Adiciona os dados à série
            foreach (var produto in produtos)
            {
                serie.Points.AddXY(produto.NomeProduto, valorY(produto));
            }

            chart.Series.Add(serie);

            // Configurações de título e eixos
            chart.Titles.Add(titulo);
            chartArea.AxisX.Title = eixoX;
            chartArea.AxisY.Title = eixoY;

            // Salva o gráfico como imagem
            chart.SaveImage(caminhoArquivo, ChartImageFormat.Png);
        }
        private async void btnDownload_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbFiltro.SelectedItem?.ToString() == "Relatório de Compras")
                {
                    // Salvar os dados tabulares como CSV
                    SaveFileDialog saveCsvDialog = new SaveFileDialog
                    {
                        Filter = "CSV File (*.csv)|*.csv",
                        Title = "Salvar Relatório de Compras"
                    };

                    if (saveCsvDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (var writer = new StreamWriter(saveCsvDialog.FileName))
                        {
                            // Cabeçalhos
                            writer.WriteLine("Data da Compra,Produto, Quantidade,Total Gasto,Fornecedor");

                            // Linhas de dados
                            foreach (DataGridViewRow row in grdRelatorios.Rows)
                            {
                                if (!row.IsNewRow)
                                {
                                    var line = string.Join(",", row.Cells.Cast<DataGridViewCell>().Select(c => c.Value?.ToString()));
                                    writer.WriteLine(line);
                                }
                            }
                        }
                        MessageBox.Show("Relatório CSV salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                // Verifica o tipo de relatório selecionado
                if (cmbFiltro.SelectedItem?.ToString() == "Relatório de Produtos")
                {
                    // Salvar gráfico de quantidade vendida por produto
                    SaveFileDialog saveGraphDialog1 = new SaveFileDialog
                    {
                        Filter = "PNG Image (*.png)|*.png",
                        Title = "Salvar Gráfico de Quantidade Vendida"
                    };

                    if (saveGraphDialog1.ShowDialog() == DialogResult.OK)
                    {
                        var produtos = await ObterProdutosFiltrados();
                        CriarGraficoProdutos(produtos, saveGraphDialog1.FileName,
                            "Quantidade Vendida por Produto", "Produto", "Quantidade Vendida",
                            p => (double)p.QuantidadeVendida);

                        MessageBox.Show("Gráfico de quantidade vendida salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    // Salvar gráfico de receita por produto
                    SaveFileDialog saveGraphDialog2 = new SaveFileDialog
                    {
                        Filter = "PNG Image (*.png)|*.png",
                        Title = "Salvar Gráfico de Receita por Produto"
                    };

                    if (saveGraphDialog2.ShowDialog() == DialogResult.OK)
                    {
                        var produtos = await ObterProdutosFiltrados();
                        CriarGraficoProdutos(produtos, saveGraphDialog2.FileName,
                            "Receita por Produto", "Produto", "Receita (R$)",
                            p => (double)p.TotalReceita);

                        MessageBox.Show("Gráfico de receita salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    // Salvar os dados tabulares como CSV
                    SaveFileDialog saveCsvDialog = new SaveFileDialog
                    {
                        Filter = "CSV File (*.csv)|*.csv",
                        Title = "Salvar Relatório de Produtos"
                    };

                    if (saveCsvDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (var writer = new StreamWriter(saveCsvDialog.FileName))
                        {
                            // Cabeçalhos
                            writer.WriteLine("Produto,Quantidade Vendida,Receita Total");

                            // Linhas de dados
                            foreach (DataGridViewRow row in grdRelatorios.Rows)
                            {
                                if (!row.IsNewRow)
                                {
                                    var line = string.Join(",", row.Cells.Cast<DataGridViewCell>().Select(c => c.Value?.ToString()));
                                    writer.WriteLine(line);
                                }
                            }
                        }
                        MessageBox.Show("Relatório CSV salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (cmbFiltro.SelectedItem?.ToString() == "Relatório de Vendas")
                {
                    // Salvar o XML da nota fiscal
                    SaveFileDialog saveXmlDialog = new SaveFileDialog
                    {
                        Filter = "XML File (*.xml)|*.xml",
                        Title = "Salvar Nota Fiscal"
                    };

                    if (saveXmlDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Obtém o intervalo de datas
                        DateTime dataInicio = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1); // Primeiro dia do mês atual
                        DateTime dataFim = dteFim.Value.Date.AddDays(1).AddSeconds(-1); // Final do dia escolhido

                        // Carrega as vendas do serviço
                        var vendas = await _vendaService.ObterTodosVendas();

                        // Filtra as vendas pelo intervalo
                        var vendasFiltradas = vendas
                            .Where(v => v.Inclusao >= dataInicio && v.Inclusao <= dataFim)
                            .ToList();

                        if (!vendasFiltradas.Any())
                        {
                            MessageBox.Show("Nenhuma venda encontrada no período selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        // Criação do XML
                        XDocument xmlNotaFiscal = new XDocument(
                            new XElement("NotaFiscal",
                                new XElement("Emitente",
                                    new XElement("CNPJ", "00.000.000/0001-00"),
                                    new XElement("RazaoSocial", "FelineForce LTDA"),
                                    new XElement("Endereco", "Rua Unesp, 123, Bairro, Bauru, São Paulo")
                                ),
                                new XElement("Itens",
                                    from venda in vendasFiltradas
                                    select new XElement("Item",
                                        new XElement("CPF_Cliente", venda.CPFCliente ?? "Não consta"),
                                        new XElement("Quantidade", venda.Itens.First().Quantidade),
                                        new XElement("ValorUnitario", Math.Round(venda.Itens.First().Total / venda.Itens.First().Quantidade,2)),
                                        new XElement("TotalItem", Math.Round(venda.TotalCompra,2))
                                    )
                                ),
                                new XElement("Totais",
                                    new XElement("ValorTotal", vendasFiltradas.Sum(v => v.TotalCompra)),
                                    new XElement("Impostos", 0) // Para simulação, o imposto é zero
                                ),
                                new XElement("DataEmissao", DateTime.Now.ToString("yyyy-MM-dd"))
                            )
                        );

                        // Salvar o XML no arquivo selecionado
                        xmlNotaFiscal.Save(saveXmlDialog.FileName);
                        MessageBox.Show("Nota fiscal gerada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    // Salvar o gráfico de faturamento
                    SaveFileDialog saveGraphDialog = new SaveFileDialog
                    {
                        Filter = "PNG Image (*.png)|*.png",
                        Title = "Salvar Gráfico de Faturamento"
                    };

                    if (saveGraphDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Obtém o intervalo de datas
                        DateTime dataInicio = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1); // Primeiro dia do mês atual
                        DateTime dataFim = dteFim.Value.Date.AddDays(1).AddSeconds(-1); // Final do dia escolhido

                        // Carrega as vendas do serviço
                        var vendas = await _vendaService.ObterTodosVendas();

                        // Filtra as vendas pelo intervalo
                        var vendasFiltradas = vendas
                            .Where(v => v.Inclusao >= dataInicio && v.Inclusao <= dataFim)
                            .ToList();

                        if (!vendasFiltradas.Any())
                        {
                            MessageBox.Show("Nenhuma venda encontrada no período selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        // Agrupa por mês e calcula o total faturado
                        var faturamentoMensal = vendasFiltradas
                            .GroupBy(v => v.Inclusao.Month)
                            .Select(g => new FaturamentoMensal
                            {
                                Mes = g.Key,
                                TotalFaturado = Math.Round(g.Sum(v => v.TotalCompra), 2)
                            })
                            .ToList();

                        // Cria e salva o gráfico
                        //CriarGraficoFaturamento(faturamentoMensal, saveGraphDialog.FileName);

                        //MessageBox.Show("Gráfico salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    // Salvar os dados tabulares como CSV
                    SaveFileDialog saveCsvDialog = new SaveFileDialog
                    {
                        Filter = "CSV File (*.csv)|*.csv",
                        Title = "Salvar Relatório de Vendas"
                    };

                    if (saveCsvDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (var writer = new StreamWriter(saveCsvDialog.FileName))
                        {
                            // Cabeçalhos
                            writer.WriteLine("Data da Venda,CPF do Cliente,Total da Compra,Quantidade de Itens");

                            // Linhas de dados
                            foreach (DataGridViewRow row in grdRelatorios.Rows)
                            {
                                if (!row.IsNewRow)
                                {
                                    var line = string.Join(",", row.Cells.Cast<DataGridViewCell>().Select(c => c.Value?.ToString()));
                                    writer.WriteLine(line);
                                }
                            }
                        }
                        MessageBox.Show("Relatório CSV salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (cmbFiltro.SelectedItem?.ToString() == "Relatório de Lucratividade")
                {
                    // Salvar CSV de lucratividade
                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "Arquivo CSV (*.csv)|*.csv",
                        FileName = "relatorio_lucratividade.csv"
                    };

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (var writer = new StreamWriter(saveFileDialog.FileName))
                        {
                            // Escreve o cabeçalho do arquivo CSV
                            writer.WriteLine("Produto,Quantidade Vendida,Custo Total (R$),Receita Total (R$),Lucro (R$)");

                            // Escreve os dados do DataGridView
                            foreach (DataGridViewRow row in grdRelatorios.Rows)
                            {
                                var linha = string.Join(",",
                                    row.Cells["Produto"].Value,
                                    row.Cells["QuantidadeVendida"].Value,
                                    row.Cells["CustoTotal"].Value,
                                    row.Cells["ReceitaTotal"].Value,
                                    row.Cells["Lucro"].Value
                                );
                                writer.WriteLine(linha);
                            }
                        }
                        MessageBox.Show("Relatório CSV salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    // Solicitar o arquivo CSV para salvar o gráfico de lucratividade
                    SaveFileDialog saveGraphDialog = new SaveFileDialog
                    {
                        Filter = "PNG Image (*.png)|*.png",
                        Title = "Salvar Gráfico de Lucratividade por Produto"
                    };

                    if (saveGraphDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Carregar os dados do CSV (usando o caminho do arquivo salvo)
                        var produtos = CarregarDadosCsv(saveFileDialog.FileName);

                        // Gerar o gráfico de lucratividade
                        CriarGraficoLucratividade(produtos, saveGraphDialog.FileName,
                            "Lucro por Produto", "Produto", "Lucro",
                            p => p.Preco); // Usando o lucro como valor para o gráfico

                        MessageBox.Show("Gráfico de lucratividade salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (cmbFiltro.SelectedItem?.ToString() == "Relatório de Logs")
                {
                    SaveFileDialog saveCsvDialog = new SaveFileDialog
                    {
                        Filter = "CSV File (*.csv)|*.csv",
                        Title = "Salvar Relatório de Logs"
                    };

                    if (saveCsvDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (var writer = new StreamWriter(saveCsvDialog.FileName))
                        {
                            // Cabeçalhos
                            writer.WriteLine("Data do Log,Tipo de Log,Mensagem,Criado Por");

                            // Linhas de dados
                            foreach (DataGridViewRow row in grdRelatorios.Rows)
                            {
                                if (!row.IsNewRow)
                                {
                                    var line = string.Join(",", row.Cells.Cast<DataGridViewCell>().Select(c => c.Value?.ToString()));
                                    writer.WriteLine(line);
                                }
                            }
                        }
                        MessageBox.Show("Relatório CSV salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar os arquivos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private List<Produto> CarregarDadosCsv(string caminhoArquivo)
        {
            var produtos = new List<Produto>();

            using (var reader = new StreamReader(caminhoArquivo))
            {
                // Ignorar a primeira linha (cabeçalho)
                reader.ReadLine();

                // Ler as linhas restantes
                while (!reader.EndOfStream)
                {
                    var linha = reader.ReadLine();
                    var valores = linha.Split(',');

                    // Criar o objeto Produto e adicionar à lista
                    var produto = new Produto
                    {
                        Nome = valores[0],
                        Preco = (float)Convert.ToDouble(valores[4])
                    };

                    produtos.Add(produto);
                }
            }

            return produtos;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void CriarGraficoLucratividade(IEnumerable<Produto> produtos, string caminhoArquivo, string titulo, string eixoX, string eixoY, Func<Produto, double> valor)
        {
            // Criando o gráfico
            var chart = new Chart
            {
                Width = 600,
                Height = 400
            };

            // Adiciona uma área de gráfico
            var chartArea = new ChartArea();
            chart.ChartAreas.Add(chartArea);

            // Adiciona uma série de dados para o lucro
            var serie = new Series
            {
                Name = "Lucro",
                ChartType = SeriesChartType.Column, // Tipo de gráfico de barras
                XValueType = ChartValueType.String
            };
            chart.Series.Add(serie);

            // Preenche o gráfico com os dados de lucro
            foreach (var produto in produtos)
            {
                serie.Points.AddXY(produto.Nome, valor(produto)); // Usando o valor do lucro
            }

            // Define o título
            chart.Titles.Add(titulo);

            // Configura o eixo X e Y
            chart.ChartAreas[0].AxisX.Title = eixoX;
            chart.ChartAreas[0].AxisY.Title = eixoY;

            // Salva o gráfico no arquivo especificado
            chart.SaveImage(caminhoArquivo, ChartImageFormat.Png);
        }

    }
}
public class FaturamentoMensal
{
    public int Mes { get; set; } // 1 para Janeiro, 2 para Fevereiro, etc.
    public decimal TotalFaturado { get; set; } // Faturamento total no mês
}