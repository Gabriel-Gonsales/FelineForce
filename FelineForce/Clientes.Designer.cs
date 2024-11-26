namespace ERP_com_relatorio
{
    partial class frmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            txtPesquisa = new TextBox();
            btnProcurar = new Button();
            grdClientes = new DataGridView();
            Check = new DataGridViewCheckBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Telefone = new DataGridViewTextBoxColumn();
            Endereco = new DataGridViewTextBoxColumn();
            btnVoltar = new Button();
            btnExcluir = new Button();
            btnCadastrar = new Button();
            btnEditar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdClientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(200, 62, 77);
            label1.Location = new Point(149, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(189, 52);
            label1.TabIndex = 10;
            label1.Text = "Clientes";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 14);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
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
            txtPesquisa.TabIndex = 15;
            txtPesquisa.WordWrap = false;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
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
            btnProcurar.TabIndex = 16;
            btnProcurar.Text = "Procurar";
            btnProcurar.UseVisualStyleBackColor = false;
            btnProcurar.Click += btnProcurar_Click;
            // 
            // grdClientes
            // 
            grdClientes.AllowUserToAddRows = false;
            grdClientes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            grdClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            grdClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grdClientes.BackgroundColor = Color.FromArgb(200, 62, 77);
            grdClientes.BorderStyle = BorderStyle.Fixed3D;
            grdClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdClientes.Columns.AddRange(new DataGridViewColumn[] { Check, Nome, Email, Telefone, Endereco });
            grdClientes.Location = new Point(55, 149);
            grdClientes.Margin = new Padding(4, 3, 4, 3);
            grdClientes.Name = "grdClientes";
            grdClientes.Size = new Size(1043, 472);
            grdClientes.TabIndex = 17;
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
            // Nome
            // 
            Nome.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Nome.HeaderText = "Nome";
            Nome.MinimumWidth = 180;
            Nome.Name = "Nome";
            Nome.Width = 180;
            // 
            // Email
            // 
            Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Email.HeaderText = "Email";
            Email.MinimumWidth = 180;
            Email.Name = "Email";
            Email.Width = 180;
            // 
            // Telefone
            // 
            Telefone.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Telefone.HeaderText = "Telefone";
            Telefone.MinimumWidth = 180;
            Telefone.Name = "Telefone";
            Telefone.Width = 180;
            // 
            // Endereco
            // 
            Endereco.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Endereco.HeaderText = "Endereço";
            Endereco.MinimumWidth = 230;
            Endereco.Name = "Endereco";
            Endereco.Width = 230;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(200, 62, 77);
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.ForeColor = Color.White;
            btnVoltar.Location = new Point(980, 652);
            btnVoltar.Margin = new Padding(0);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(120, 44);
            btnVoltar.TabIndex = 18;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.FromArgb(200, 62, 77);
            btnExcluir.FlatAppearance.BorderSize = 0;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.ForeColor = Color.White;
            btnExcluir.Location = new Point(822, 652);
            btnExcluir.Margin = new Padding(0);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(120, 44);
            btnExcluir.TabIndex = 19;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.FromArgb(200, 62, 77);
            btnCadastrar.FlatAppearance.BorderSize = 0;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = Color.White;
            btnCadastrar.Location = new Point(500, 652);
            btnCadastrar.Margin = new Padding(0);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(131, 44);
            btnCadastrar.TabIndex = 20;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(200, 62, 77);
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(670, 652);
            btnEditar.Margin = new Padding(0);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(112, 44);
            btnEditar.TabIndex = 21;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // frmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 154, 87);
            ClientSize = new Size(1168, 721);
            Controls.Add(btnEditar);
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
            Name = "frmClientes";
            Text = "Clientes";
            FormClosed += frmClientes_FormClosed;
            Load += Clientes_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.DataGridView grdClientes;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereco;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnEditar;
    }
}