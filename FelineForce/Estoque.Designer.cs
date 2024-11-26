namespace ERP_com_relatorio
{
    partial class frmEstoque
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstoque));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btnProcurar = new Button();
            txtPesquisa = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            grdClientes = new DataGridView();
            Check = new DataGridViewCheckBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            Descricao = new DataGridViewTextBoxColumn();
            Preco = new DataGridViewTextBoxColumn();
            Quantidade = new DataGridViewTextBoxColumn();
            btnCadastrar = new Button();
            btnExcluir = new Button();
            btnVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdClientes).BeginInit();
            SuspendLayout();
            // 
            // btnProcurar
            // 
            btnProcurar.BackColor = Color.FromArgb(200, 62, 77);
            btnProcurar.FlatAppearance.BorderSize = 0;
            btnProcurar.FlatStyle = FlatStyle.Flat;
            btnProcurar.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProcurar.ForeColor = Color.White;
            btnProcurar.Location = new Point(974, 46);
            btnProcurar.Margin = new Padding(0);
            btnProcurar.Name = "btnProcurar";
            btnProcurar.Size = new Size(120, 44);
            btnProcurar.TabIndex = 20;
            btnProcurar.Text = "Procurar";
            btnProcurar.UseVisualStyleBackColor = false;
            btnProcurar.Click += btnProcurar_Click;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPesquisa.ForeColor = Color.FromArgb(200, 62, 77);
            txtPesquisa.Location = new Point(558, 46);
            txtPesquisa.Margin = new Padding(4, 3, 4, 3);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.ShortcutsEnabled = false;
            txtPesquisa.Size = new Size(372, 40);
            txtPesquisa.TabIndex = 19;
            txtPesquisa.WordWrap = false;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(200, 62, 77);
            label1.Location = new Point(149, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(188, 52);
            label1.TabIndex = 18;
            label1.Text = "Estoque";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 14);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // grdClientes
            // 
            grdClientes.AllowUserToAddRows = false;
            grdClientes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grdClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            grdClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grdClientes.BackgroundColor = Color.FromArgb(200, 62, 77);
            grdClientes.BorderStyle = BorderStyle.Fixed3D;
            grdClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdClientes.Columns.AddRange(new DataGridViewColumn[] { Check, Id, Descricao, Preco, Quantidade });
            grdClientes.Location = new Point(51, 129);
            grdClientes.Margin = new Padding(4, 3, 4, 3);
            grdClientes.Name = "grdClientes";
            grdClientes.Size = new Size(1065, 472);
            grdClientes.TabIndex = 21;
            grdClientes.CellContentClick += grdClientes_CellContentClick;
            // 
            // Check
            // 
            Check.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Check.HeaderText = "";
            Check.MinimumWidth = 80;
            Check.Name = "Check";
            Check.Width = 80;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Id.HeaderText = "ID";
            Id.MinimumWidth = 100;
            Id.Name = "Id";
            // 
            // Descricao
            // 
            Descricao.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Descricao.HeaderText = "Descrição";
            Descricao.MinimumWidth = 280;
            Descricao.Name = "Descricao";
            Descricao.Width = 280;
            // 
            // Preco
            // 
            Preco.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Preco.HeaderText = "Preço/Unidade";
            Preco.MinimumWidth = 180;
            Preco.Name = "Preco";
            Preco.Width = 180;
            // 
            // Quantidade
            // 
            Quantidade.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Quantidade.HeaderText = "Quantidade";
            Quantidade.MinimumWidth = 230;
            Quantidade.Name = "Quantidade";
            Quantidade.Width = 230;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.FromArgb(200, 62, 77);
            btnCadastrar.FlatAppearance.BorderSize = 0;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = Color.White;
            btnCadastrar.Location = new Point(645, 648);
            btnCadastrar.Margin = new Padding(0);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(131, 44);
            btnCadastrar.TabIndex = 24;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.FromArgb(200, 62, 77);
            btnExcluir.FlatAppearance.BorderSize = 0;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.ForeColor = Color.White;
            btnExcluir.Location = new Point(810, 648);
            btnExcluir.Margin = new Padding(0);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(120, 44);
            btnExcluir.TabIndex = 23;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click_1;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(200, 62, 77);
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.ForeColor = Color.White;
            btnVoltar.Location = new Point(967, 648);
            btnVoltar.Margin = new Padding(0);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(120, 44);
            btnVoltar.TabIndex = 22;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // frmEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 154, 87);
            ClientSize = new Size(1168, 721);
            Controls.Add(btnCadastrar);
            Controls.Add(btnExcluir);
            Controls.Add(btnVoltar);
            Controls.Add(grdClientes);
            Controls.Add(btnProcurar);
            Controls.Add(txtPesquisa);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MaximumSize = new Size(1184, 760);
            MinimumSize = new Size(1184, 760);
            Name = "frmEstoque";
            Text = "Estoque";
            FormClosed += frmEstoque_FormClosed;
            Load += frmEstoque_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView grdClientes;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnVoltar;
    }
}