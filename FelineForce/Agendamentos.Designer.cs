namespace ERP_com_relatorio
{
    partial class frmAgendamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgendamentos));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            lblAgendamento = new Label();
            pictureBox1 = new PictureBox();
            grdAgendamentos = new DataGridView();
            DataHora = new DataGridViewTextBoxColumn();
            Gato = new DataGridViewTextBoxColumn();
            Agendamento = new DataGridViewTextBoxColumn();
            btnVoltar = new Button();
            btnAgendar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdAgendamentos).BeginInit();
            SuspendLayout();
            // 
            // lblAgendamento
            // 
            lblAgendamento.AutoSize = true;
            lblAgendamento.Font = new Font("Arial Black", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAgendamento.ForeColor = Color.FromArgb(200, 62, 77);
            lblAgendamento.Location = new Point(149, 32);
            lblAgendamento.Margin = new Padding(4, 0, 4, 0);
            lblAgendamento.Name = "lblAgendamento";
            lblAgendamento.Size = new Size(366, 52);
            lblAgendamento.TabIndex = 12;
            lblAgendamento.Text = "Agendamento de";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 14);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // grdAgendamentos
            // 
            grdAgendamentos.AllowUserToAddRows = false;
            grdAgendamentos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grdAgendamentos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            grdAgendamentos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grdAgendamentos.BackgroundColor = Color.FromArgb(200, 62, 77);
            grdAgendamentos.BorderStyle = BorderStyle.Fixed3D;
            grdAgendamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdAgendamentos.Columns.AddRange(new DataGridViewColumn[] { DataHora, Gato, Agendamento });
            grdAgendamentos.Location = new Point(192, 130);
            grdAgendamentos.Margin = new Padding(4, 3, 4, 3);
            grdAgendamentos.Name = "grdAgendamentos";
            grdAgendamentos.Size = new Size(827, 472);
            grdAgendamentos.TabIndex = 18;
            grdAgendamentos.CellContentClick += grdAgendamentos_CellContentClick;
            // 
            // DataHora
            // 
            DataHora.Frozen = true;
            DataHora.HeaderText = "Data e Hora";
            DataHora.MinimumWidth = 222;
            DataHora.Name = "DataHora";
            DataHora.Width = 222;
            // 
            // Gato
            // 
            Gato.HeaderText = "Gato";
            Gato.MinimumWidth = 222;
            Gato.Name = "Gato";
            Gato.Width = 222;
            // 
            // Agendamento
            // 
            Agendamento.HeaderText = "Agendamento";
            Agendamento.MinimumWidth = 222;
            Agendamento.Name = "Agendamento";
            Agendamento.Width = 222;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(200, 62, 77);
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.ForeColor = Color.White;
            btnVoltar.Location = new Point(178, 632);
            btnVoltar.Margin = new Padding(0);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(120, 44);
            btnVoltar.TabIndex = 20;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnAgendar
            // 
            btnAgendar.BackColor = Color.FromArgb(200, 62, 77);
            btnAgendar.FlatAppearance.BorderSize = 0;
            btnAgendar.FlatStyle = FlatStyle.Flat;
            btnAgendar.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgendar.ForeColor = Color.White;
            btnAgendar.Location = new Point(931, 632);
            btnAgendar.Margin = new Padding(0);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(141, 44);
            btnAgendar.TabIndex = 19;
            btnAgendar.Text = "Agendar";
            btnAgendar.UseVisualStyleBackColor = false;
            btnAgendar.Click += btnAgendar_Click;
            // 
            // frmAgendamentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 154, 87);
            ClientSize = new Size(1168, 721);
            Controls.Add(btnVoltar);
            Controls.Add(btnAgendar);
            Controls.Add(grdAgendamentos);
            Controls.Add(lblAgendamento);
            Controls.Add(pictureBox1);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MaximumSize = new Size(1184, 760);
            MinimumSize = new Size(1184, 760);
            Name = "frmAgendamentos";
            Text = "Agendamento";
            FormClosed += frmAgendamentos_FormClosed;
            Load += frmAgendamentos_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdAgendamentos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblAgendamento;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView grdAgendamentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Agendamento;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAgendar;
    }
}