namespace ERP_com_relatorio
{
    partial class frmRelatorios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorios));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dteInicio = new DateTimePicker();
            label2 = new Label();
            dteFim = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            cmbFiltro = new ComboBox();
            btnGerar = new Button();
            grdRelatorios = new DataGridView();
            Usuario = new DataGridViewTextBoxColumn();
            DataHora = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            Registro = new DataGridViewTextBoxColumn();
            btnDownload = new Button();
            btnVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdRelatorios).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(4, 113, 166);
            label1.Location = new Point(149, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(205, 52);
            label1.TabIndex = 25;
            label1.Text = "Relatório";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 14);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // dteInicio
            // 
            dteInicio.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold);
            dteInicio.Format = DateTimePickerFormat.Short;
            dteInicio.Location = new Point(68, 188);
            dteInicio.Margin = new Padding(4, 3, 4, 3);
            dteInicio.Name = "dteInicio";
            dteInicio.Size = new Size(215, 40);
            dteInicio.TabIndex = 27;
            dteInicio.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dteInicio.ValueChanged += dteInicio_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(4, 113, 166);
            label2.Location = new Point(59, 138);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(178, 38);
            label2.TabIndex = 26;
            label2.Text = "Data Início";
            // 
            // dteFim
            // 
            dteFim.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold);
            dteFim.Format = DateTimePickerFormat.Short;
            dteFim.Location = new Point(382, 188);
            dteFim.Margin = new Padding(4, 3, 4, 3);
            dteFim.Name = "dteFim";
            dteFim.Size = new Size(215, 40);
            dteFim.TabIndex = 29;
            dteFim.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dteFim.ValueChanged += dteFim_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(4, 113, 166);
            label3.Location = new Point(373, 138);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(149, 38);
            label3.TabIndex = 28;
            label3.Text = "Data Fim";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(4, 113, 166);
            label4.Location = new Point(693, 138);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(95, 38);
            label4.TabIndex = 30;
            label4.Text = "Filtro";
            // 
            // cmbFiltro
            // 
            cmbFiltro.BackColor = Color.White;
            cmbFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiltro.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold);
            cmbFiltro.FormattingEnabled = true;
            cmbFiltro.Items.AddRange(new object[] { "Login", "Vendas", "Compras", "Gatos", "Usuários", "Agendamentos" });
            cmbFiltro.Location = new Point(701, 186);
            cmbFiltro.Margin = new Padding(4, 3, 4, 3);
            cmbFiltro.Name = "cmbFiltro";
            cmbFiltro.Size = new Size(265, 41);
            cmbFiltro.TabIndex = 48;
            cmbFiltro.SelectedIndexChanged += cmbFiltro_SelectedIndexChanged;
            // 
            // btnGerar
            // 
            btnGerar.BackColor = Color.FromArgb(4, 113, 166);
            btnGerar.FlatAppearance.BorderSize = 0;
            btnGerar.FlatStyle = FlatStyle.Flat;
            btnGerar.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGerar.ForeColor = Color.White;
            btnGerar.Location = new Point(1013, 188);
            btnGerar.Margin = new Padding(0);
            btnGerar.Name = "btnGerar";
            btnGerar.Size = new Size(120, 44);
            btnGerar.TabIndex = 49;
            btnGerar.Text = "Gerar";
            btnGerar.UseVisualStyleBackColor = false;
            btnGerar.Click += btnGerar_Click;
            // 
            // grdRelatorios
            // 
            grdRelatorios.AllowUserToAddRows = false;
            grdRelatorios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            grdRelatorios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            grdRelatorios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grdRelatorios.BackgroundColor = Color.FromArgb(4, 113, 166);
            grdRelatorios.BorderStyle = BorderStyle.Fixed3D;
            grdRelatorios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdRelatorios.Columns.AddRange(new DataGridViewColumn[] { Usuario, DataHora, Tipo, Registro });
            grdRelatorios.Location = new Point(68, 282);
            grdRelatorios.Margin = new Padding(4, 3, 4, 3);
            grdRelatorios.Name = "grdRelatorios";
            grdRelatorios.Size = new Size(1030, 358);
            grdRelatorios.TabIndex = 50;
            grdRelatorios.CellContentClick += grdRelatorios_CellContentClick;
            // 
            // Usuario
            // 
            Usuario.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Usuario.HeaderText = "Usuário";
            Usuario.MinimumWidth = 180;
            Usuario.Name = "Usuario";
            Usuario.Width = 180;
            // 
            // DataHora
            // 
            DataHora.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DataHora.HeaderText = "Data e Hora";
            DataHora.MinimumWidth = 180;
            DataHora.Name = "DataHora";
            DataHora.Width = 180;
            // 
            // Tipo
            // 
            Tipo.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Tipo.HeaderText = "Tipo";
            Tipo.MinimumWidth = 180;
            Tipo.Name = "Tipo";
            Tipo.Width = 180;
            // 
            // Registro
            // 
            Registro.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Registro.HeaderText = "Registro";
            Registro.MinimumWidth = 300;
            Registro.Name = "Registro";
            Registro.Width = 300;
            // 
            // btnDownload
            // 
            btnDownload.BackColor = Color.FromArgb(4, 113, 166);
            btnDownload.FlatAppearance.BorderSize = 0;
            btnDownload.FlatStyle = FlatStyle.Flat;
            btnDownload.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDownload.ForeColor = Color.White;
            btnDownload.Location = new Point(684, 654);
            btnDownload.Margin = new Padding(0);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(161, 44);
            btnDownload.TabIndex = 51;
            btnDownload.Text = "Baixar Log";
            btnDownload.UseVisualStyleBackColor = false;
            btnDownload.Click += btnDownload_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(4, 113, 166);
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.ForeColor = Color.White;
            btnVoltar.Location = new Point(937, 654);
            btnVoltar.Margin = new Padding(0);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(161, 44);
            btnVoltar.TabIndex = 52;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // frmRelatorios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 154, 87);
            ClientSize = new Size(1168, 721);
            Controls.Add(btnVoltar);
            Controls.Add(btnDownload);
            Controls.Add(grdRelatorios);
            Controls.Add(btnGerar);
            Controls.Add(cmbFiltro);
            Controls.Add(label4);
            Controls.Add(dteFim);
            Controls.Add(label3);
            Controls.Add(dteInicio);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MaximumSize = new Size(1184, 760);
            MinimumSize = new Size(1184, 760);
            Name = "frmRelatorios";
            Text = "Relatórios do Sistema";
            FormClosed += frmRelatorios_FormClosed;
            Load += frmRelatorios_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdRelatorios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dteInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dteFim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.DataGridView grdRelatorios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Registro;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnVoltar;
    }
}