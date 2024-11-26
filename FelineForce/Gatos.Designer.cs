namespace ERP_com_relatorio
{
    partial class frmGatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGatos));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btnProcurar = new Button();
            txtPesquisa = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnEditar = new Button();
            btnCadastrar = new Button();
            btnExcluir = new Button();
            btnVoltar = new Button();
            grdGatos = new DataGridView();
            Check = new DataGridViewCheckBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Cores = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdGatos).BeginInit();
            SuspendLayout();
            // 
            // btnProcurar
            // 
            btnProcurar.BackColor = Color.FromArgb(200, 62, 77);
            btnProcurar.FlatAppearance.BorderSize = 0;
            btnProcurar.FlatStyle = FlatStyle.Flat;
            btnProcurar.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProcurar.ForeColor = Color.White;
            btnProcurar.Location = new Point(1006, 57);
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
            txtPesquisa.Location = new Point(589, 57);
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
            label1.Location = new Point(181, 43);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(141, 52);
            label1.TabIndex = 18;
            label1.Text = "Gatos";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(46, 24);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(200, 62, 77);
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(664, 655);
            btnEditar.Margin = new Padding(0);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(131, 44);
            btnEditar.TabIndex = 26;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.FromArgb(200, 62, 77);
            btnCadastrar.FlatAppearance.BorderSize = 0;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = Color.White;
            btnCadastrar.Location = new Point(502, 655);
            btnCadastrar.Margin = new Padding(0);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(131, 44);
            btnCadastrar.TabIndex = 25;
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
            btnExcluir.Location = new Point(824, 655);
            btnExcluir.Margin = new Padding(0);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(120, 44);
            btnExcluir.TabIndex = 24;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(200, 62, 77);
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.ForeColor = Color.White;
            btnVoltar.Location = new Point(981, 655);
            btnVoltar.Margin = new Padding(0);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(120, 44);
            btnVoltar.TabIndex = 23;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // grdGatos
            // 
            grdGatos.AllowUserToAddRows = false;
            grdGatos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grdGatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            grdGatos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grdGatos.BackgroundColor = Color.FromArgb(200, 62, 77);
            grdGatos.BorderStyle = BorderStyle.Fixed3D;
            grdGatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdGatos.Columns.AddRange(new DataGridViewColumn[] { Check, ID, Nome, Cores, Cliente });
            grdGatos.Location = new Point(82, 152);
            grdGatos.Margin = new Padding(4, 3, 4, 3);
            grdGatos.Name = "grdGatos";
            grdGatos.Size = new Size(948, 472);
            grdGatos.TabIndex = 22;
            grdGatos.CellContentClick += grdGatos_CellContentClick;
            // 
            // Check
            // 
            Check.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Check.HeaderText = "";
            Check.MinimumWidth = 80;
            Check.Name = "Check";
            Check.Width = 80;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ID.HeaderText = "ID do Gato";
            ID.MinimumWidth = 100;
            ID.Name = "ID";
            // 
            // Nome
            // 
            Nome.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Nome.HeaderText = "Nome";
            Nome.MinimumWidth = 180;
            Nome.Name = "Nome";
            Nome.Width = 180;
            // 
            // Cores
            // 
            Cores.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Cores.HeaderText = "Cores";
            Cores.MinimumWidth = 180;
            Cores.Name = "Cores";
            Cores.Width = 180;
            // 
            // Cliente
            // 
            Cliente.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Cliente.HeaderText = "Cliente";
            Cliente.MinimumWidth = 230;
            Cliente.Name = "Cliente";
            Cliente.Width = 230;
            // 
            // frmGatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 154, 87);
            ClientSize = new Size(1168, 721);
            Controls.Add(btnEditar);
            Controls.Add(btnCadastrar);
            Controls.Add(btnExcluir);
            Controls.Add(btnVoltar);
            Controls.Add(grdGatos);
            Controls.Add(btnProcurar);
            Controls.Add(txtPesquisa);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MaximumSize = new Size(1184, 760);
            MinimumSize = new Size(1184, 760);
            Name = "frmGatos";
            Text = "Gatos";
            FormClosed += frmGatos_FormClosed;
            Load += frmGatos_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdGatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridView grdGatos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
    }
}