namespace ERP_com_relatorio
{
    partial class frmVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVenda));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            txtCPF = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            grdAgendamentos = new DataGridView();
            Item = new DataGridViewTextBoxColumn();
            Quantidade = new DataGridViewTextBoxColumn();
            Agendamento = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            txtTotalFinal = new TextBox();
            label4 = new Label();
            txtDescontos = new TextBox();
            label3 = new Label();
            txtTotal = new TextBox();
            label5 = new Label();
            btnProsseguir = new Button();
            btnVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdAgendamentos).BeginInit();
            SuspendLayout();
            // 
            // txtCPF
            // 
            txtCPF.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCPF.ForeColor = Color.FromArgb(200, 62, 77);
            txtCPF.Location = new Point(771, 45);
            txtCPF.Margin = new Padding(4, 3, 4, 3);
            txtCPF.Name = "txtCPF";
            txtCPF.ShortcutsEnabled = false;
            txtCPF.Size = new Size(372, 40);
            txtCPF.TabIndex = 22;
            txtCPF.WordWrap = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(200, 62, 77);
            label1.Location = new Point(149, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(149, 52);
            label1.TabIndex = 21;
            label1.Text = "Venda";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 14);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(200, 62, 77);
            label2.Location = new Point(462, 43);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(259, 42);
            label2.TabIndex = 23;
            label2.Text = "CPF do Cliente";
            // 
            // grdAgendamentos
            // 
            grdAgendamentos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grdAgendamentos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            grdAgendamentos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grdAgendamentos.BackgroundColor = Color.FromArgb(200, 62, 77);
            grdAgendamentos.BorderStyle = BorderStyle.Fixed3D;
            grdAgendamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdAgendamentos.Columns.AddRange(new DataGridViewColumn[] { Item, Quantidade, Agendamento, Total });
            grdAgendamentos.Location = new Point(44, 123);
            grdAgendamentos.Margin = new Padding(4, 3, 4, 3);
            grdAgendamentos.Name = "grdAgendamentos";
            grdAgendamentos.Size = new Size(518, 472);
            grdAgendamentos.TabIndex = 24;
            grdAgendamentos.CellContentClick += grdAgendamentos_CellContentClick;
            grdAgendamentos.CellValueChanged += grdAgendamentos_CellValueChanged;
            // 
            // Item
            // 
            Item.Frozen = true;
            Item.HeaderText = "Item";
            Item.MinimumWidth = 100;
            Item.Name = "Item";
            // 
            // Quantidade
            // 
            Quantidade.HeaderText = "Quantidade";
            Quantidade.MinimumWidth = 100;
            Quantidade.Name = "Quantidade";
            // 
            // Agendamento
            // 
            Agendamento.HeaderText = "Preço/Unidade";
            Agendamento.MinimumWidth = 100;
            Agendamento.Name = "Agendamento";
            Agendamento.ReadOnly = true;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.MinimumWidth = 100;
            Total.Name = "Total";
            Total.ReadOnly = true;
            // 
            // txtTotalFinal
            // 
            txtTotalFinal.Enabled = false;
            txtTotalFinal.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTotalFinal.ForeColor = Color.FromArgb(200, 62, 77);
            txtTotalFinal.Location = new Point(685, 475);
            txtTotalFinal.Margin = new Padding(4, 3, 4, 3);
            txtTotalFinal.Name = "txtTotalFinal";
            txtTotalFinal.ShortcutsEnabled = false;
            txtTotalFinal.Size = new Size(372, 40);
            txtTotalFinal.TabIndex = 30;
            txtTotalFinal.TextAlign = HorizontalAlignment.Right;
            txtTotalFinal.WordWrap = false;
            txtTotalFinal.TextChanged += txtTotalFinal_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(200, 62, 77);
            label4.Location = new Point(677, 428);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(173, 38);
            label4.TabIndex = 29;
            label4.Text = "Total Final";
            // 
            // txtDescontos
            // 
            txtDescontos.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDescontos.ForeColor = Color.FromArgb(200, 62, 77);
            txtDescontos.Location = new Point(685, 330);
            txtDescontos.Margin = new Padding(4, 3, 4, 3);
            txtDescontos.Name = "txtDescontos";
            txtDescontos.ShortcutsEnabled = false;
            txtDescontos.Size = new Size(372, 40);
            txtDescontos.TabIndex = 28;
            txtDescontos.Text = "0,00";
            txtDescontos.TextAlign = HorizontalAlignment.Right;
            txtDescontos.WordWrap = false;
            txtDescontos.TextChanged += txtDescontos_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(200, 62, 77);
            label3.Location = new Point(677, 283);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(174, 38);
            label3.TabIndex = 27;
            label3.Text = "Descontos";
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTotal.ForeColor = Color.FromArgb(200, 62, 77);
            txtTotal.Location = new Point(685, 190);
            txtTotal.Margin = new Padding(4, 3, 4, 3);
            txtTotal.Name = "txtTotal";
            txtTotal.ShortcutsEnabled = false;
            txtTotal.Size = new Size(372, 40);
            txtTotal.TabIndex = 26;
            txtTotal.TextAlign = HorizontalAlignment.Right;
            txtTotal.WordWrap = false;
            txtTotal.TextChanged += txtTotal_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(200, 62, 77);
            label5.Location = new Point(677, 143);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(92, 38);
            label5.TabIndex = 25;
            label5.Text = "Total";
            // 
            // btnProsseguir
            // 
            btnProsseguir.BackColor = Color.FromArgb(200, 62, 77);
            btnProsseguir.FlatAppearance.BorderSize = 0;
            btnProsseguir.FlatStyle = FlatStyle.Flat;
            btnProsseguir.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProsseguir.ForeColor = Color.White;
            btnProsseguir.Location = new Point(863, 640);
            btnProsseguir.Margin = new Padding(0);
            btnProsseguir.Name = "btnProsseguir";
            btnProsseguir.Size = new Size(141, 44);
            btnProsseguir.TabIndex = 32;
            btnProsseguir.Text = "Prosseguir";
            btnProsseguir.UseVisualStyleBackColor = false;
            btnProsseguir.Click += btnProsseguir_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(200, 62, 77);
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.ForeColor = Color.White;
            btnVoltar.Location = new Point(92, 640);
            btnVoltar.Margin = new Padding(0);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(120, 44);
            btnVoltar.TabIndex = 31;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // frmVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 154, 87);
            ClientSize = new Size(1168, 721);
            Controls.Add(btnProsseguir);
            Controls.Add(btnVoltar);
            Controls.Add(txtTotalFinal);
            Controls.Add(label4);
            Controls.Add(txtDescontos);
            Controls.Add(label3);
            Controls.Add(txtTotal);
            Controls.Add(label5);
            Controls.Add(grdAgendamentos);
            Controls.Add(label2);
            Controls.Add(txtCPF);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MaximumSize = new Size(1184, 760);
            MinimumSize = new Size(1184, 760);
            Name = "frmVenda";
            Text = "Vendas";
            FormClosed += frmVenda_FormClosed;
            Load += frmVenda_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdAgendamentos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grdAgendamentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Agendamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.TextBox txtTotalFinal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescontos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnProsseguir;
        private System.Windows.Forms.Button btnVoltar;
    }
}