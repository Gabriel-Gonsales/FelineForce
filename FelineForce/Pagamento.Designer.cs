namespace ERP_com_relatorio
{
    partial class frmPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPagamento));
            txtTroco = new TextBox();
            label4 = new Label();
            txtRecebido = new TextBox();
            label3 = new Label();
            txtTotal = new TextBox();
            label5 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            cbxCPF = new CheckBox();
            txtCPF = new TextBox();
            btnProsseguir = new Button();
            btnVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtTroco
            // 
            txtTroco.Enabled = false;
            txtTroco.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTroco.ForeColor = Color.FromArgb(200, 62, 77);
            txtTroco.Location = new Point(402, 421);
            txtTroco.Margin = new Padding(4, 3, 4, 3);
            txtTroco.Name = "txtTroco";
            txtTroco.ShortcutsEnabled = false;
            txtTroco.Size = new Size(372, 40);
            txtTroco.TabIndex = 36;
            txtTroco.TextAlign = HorizontalAlignment.Right;
            txtTroco.WordWrap = false;
            txtTroco.TextChanged += txtTroco_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(200, 62, 77);
            label4.Location = new Point(394, 374);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(102, 38);
            label4.TabIndex = 35;
            label4.Text = "Troco";
            // 
            // txtRecebido
            // 
            txtRecebido.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRecebido.ForeColor = Color.FromArgb(200, 62, 77);
            txtRecebido.Location = new Point(402, 303);
            txtRecebido.Margin = new Padding(4, 3, 4, 3);
            txtRecebido.Name = "txtRecebido";
            txtRecebido.ShortcutsEnabled = false;
            txtRecebido.Size = new Size(372, 40);
            txtRecebido.TabIndex = 34;
            txtRecebido.Text = "0,00";
            txtRecebido.TextAlign = HorizontalAlignment.Right;
            txtRecebido.WordWrap = false;
            txtRecebido.TextChanged += txtRecebido_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(200, 62, 77);
            label3.Location = new Point(394, 256);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(154, 38);
            label3.TabIndex = 33;
            label3.Text = "Recebido";
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTotal.ForeColor = Color.FromArgb(200, 62, 77);
            txtTotal.Location = new Point(402, 188);
            txtTotal.Margin = new Padding(4, 3, 4, 3);
            txtTotal.Name = "txtTotal";
            txtTotal.ShortcutsEnabled = false;
            txtTotal.Size = new Size(372, 40);
            txtTotal.TabIndex = 32;
            txtTotal.TextAlign = HorizontalAlignment.Right;
            txtTotal.WordWrap = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(200, 62, 77);
            label5.Location = new Point(394, 141);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(92, 38);
            label5.TabIndex = 31;
            label5.Text = "Total";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(200, 62, 77);
            label1.Location = new Point(161, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(252, 52);
            label1.TabIndex = 38;
            label1.Text = "Pagamento";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(26, 14);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            // 
            // cbxCPF
            // 
            cbxCPF.Font = new Font("Arial Black", 20F, FontStyle.Bold);
            cbxCPF.ForeColor = Color.FromArgb(200, 62, 77);
            cbxCPF.Location = new Point(378, 504);
            cbxCPF.Margin = new Padding(4, 3, 4, 3);
            cbxCPF.Name = "cbxCPF";
            cbxCPF.Size = new Size(253, 62);
            cbxCPF.TabIndex = 39;
            cbxCPF.Text = "CPF na nota";
            cbxCPF.UseVisualStyleBackColor = true;
            cbxCPF.CheckedChanged += cbxCPF_CheckedChanged;
            // 
            // txtCPF
            // 
            txtCPF.Enabled = false;
            txtCPF.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCPF.ForeColor = Color.FromArgb(200, 62, 77);
            txtCPF.Location = new Point(402, 556);
            txtCPF.Margin = new Padding(4, 3, 4, 3);
            txtCPF.Name = "txtCPF";
            txtCPF.ShortcutsEnabled = false;
            txtCPF.Size = new Size(372, 40);
            txtCPF.TabIndex = 40;
            txtCPF.TextAlign = HorizontalAlignment.Right;
            txtCPF.WordWrap = false;
            txtCPF.TextChanged += txtCPF_TextChanged;
            // 
            // btnProsseguir
            // 
            btnProsseguir.BackColor = Color.FromArgb(200, 62, 77);
            btnProsseguir.FlatAppearance.BorderSize = 0;
            btnProsseguir.FlatStyle = FlatStyle.Flat;
            btnProsseguir.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProsseguir.ForeColor = Color.White;
            btnProsseguir.Location = new Point(892, 643);
            btnProsseguir.Margin = new Padding(0);
            btnProsseguir.Name = "btnProsseguir";
            btnProsseguir.Size = new Size(141, 44);
            btnProsseguir.TabIndex = 42;
            btnProsseguir.Text = "Finalizar";
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
            btnVoltar.Location = new Point(121, 643);
            btnVoltar.Margin = new Padding(0);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(120, 44);
            btnVoltar.TabIndex = 41;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // frmPagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 154, 87);
            ClientSize = new Size(1168, 721);
            Controls.Add(btnProsseguir);
            Controls.Add(btnVoltar);
            Controls.Add(txtCPF);
            Controls.Add(cbxCPF);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(txtTroco);
            Controls.Add(label4);
            Controls.Add(txtRecebido);
            Controls.Add(label3);
            Controls.Add(txtTotal);
            Controls.Add(label5);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MaximumSize = new Size(1184, 760);
            MinimumSize = new Size(1184, 760);
            Name = "frmPagamento";
            Text = "Pagamento";
            FormClosed += frmPagamento_FormClosed;
            Load += frmPagamento_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtTroco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRecebido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox cbxCPF;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Button btnProsseguir;
        private System.Windows.Forms.Button btnVoltar;
    }
}