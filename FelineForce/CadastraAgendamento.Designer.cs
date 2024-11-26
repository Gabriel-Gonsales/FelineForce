namespace ERP_com_relatorio
{
    partial class frmCadastraAgendamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastraAgendamento));
            lblAgendamento = new Label();
            pictureBox1 = new PictureBox();
            txtTelefone = new TextBox();
            label4 = new Label();
            txtNome = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            cbxBanho = new CheckBox();
            cbxTosa = new CheckBox();
            label3 = new Label();
            textBox1 = new TextBox();
            btnVoltar = new Button();
            btnAgendar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            lblAgendamento.TabIndex = 14;
            lblAgendamento.Text = "Agendamento de";
            lblAgendamento.Click += lblAgendamento_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 14);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // txtTelefone
            // 
            txtTelefone.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTelefone.ForeColor = Color.FromArgb(200, 62, 77);
            txtTelefone.Location = new Point(677, 202);
            txtTelefone.Margin = new Padding(4, 3, 4, 3);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.ShortcutsEnabled = false;
            txtTelefone.Size = new Size(372, 40);
            txtTelefone.TabIndex = 18;
            txtTelefone.WordWrap = false;
            txtTelefone.TextChanged += txtTelefone_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(200, 62, 77);
            label4.Location = new Point(668, 155);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(235, 38);
            label4.TabIndex = 17;
            label4.Text = "CPF do Cliente";
            label4.Click += label4_Click;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNome.ForeColor = Color.FromArgb(200, 62, 77);
            txtNome.Location = new Point(121, 202);
            txtNome.Margin = new Padding(4, 3, 4, 3);
            txtNome.Name = "txtNome";
            txtNome.ShortcutsEnabled = false;
            txtNome.Size = new Size(372, 40);
            txtNome.TabIndex = 16;
            txtNome.WordWrap = false;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(200, 62, 77);
            label2.Location = new Point(113, 155);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(226, 38);
            label2.TabIndex = 15;
            label2.Text = "Nome do Gato";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(200, 62, 77);
            label1.Location = new Point(113, 315);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(192, 38);
            label1.TabIndex = 19;
            label1.Text = "Data e Hora";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold);
            dateTimePicker1.Location = new Point(121, 365);
            dateTimePicker1.Margin = new Padding(4, 3, 4, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(697, 40);
            dateTimePicker1.TabIndex = 20;
            dateTimePicker1.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // cbxBanho
            // 
            cbxBanho.Checked = true;
            cbxBanho.CheckState = CheckState.Checked;
            cbxBanho.Font = new Font("Arial Black", 20F, FontStyle.Bold);
            cbxBanho.ForeColor = Color.FromArgb(200, 62, 77);
            cbxBanho.Location = new Point(876, 295);
            cbxBanho.Margin = new Padding(4, 3, 4, 3);
            cbxBanho.Name = "cbxBanho";
            cbxBanho.Size = new Size(173, 62);
            cbxBanho.TabIndex = 21;
            cbxBanho.Text = "Banho";
            cbxBanho.UseVisualStyleBackColor = true;
            cbxBanho.CheckedChanged += cbxBanho_CheckedChanged;
            // 
            // cbxTosa
            // 
            cbxTosa.Font = new Font("Arial Black", 20F, FontStyle.Bold);
            cbxTosa.ForeColor = Color.FromArgb(200, 62, 77);
            cbxTosa.Location = new Point(876, 365);
            cbxTosa.Margin = new Padding(4, 3, 4, 3);
            cbxTosa.Name = "cbxTosa";
            cbxTosa.Size = new Size(173, 62);
            cbxTosa.TabIndex = 22;
            cbxTosa.Text = "Tosa";
            cbxTosa.UseVisualStyleBackColor = true;
            cbxTosa.CheckedChanged += cbxTosa_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(200, 62, 77);
            label3.Location = new Point(113, 435);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(212, 38);
            label3.TabIndex = 23;
            label3.Text = "Observações";
            label3.Click += label3_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.FromArgb(200, 62, 77);
            textBox1.Location = new Point(121, 493);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ShortcutsEnabled = false;
            textBox1.Size = new Size(927, 126);
            textBox1.TabIndex = 24;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(200, 62, 77);
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.ForeColor = Color.White;
            btnVoltar.Location = new Point(121, 654);
            btnVoltar.Margin = new Padding(0);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(120, 44);
            btnVoltar.TabIndex = 26;
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
            btnAgendar.Location = new Point(874, 654);
            btnAgendar.Margin = new Padding(0);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(141, 44);
            btnAgendar.TabIndex = 25;
            btnAgendar.Text = "Salvar";
            btnAgendar.UseVisualStyleBackColor = false;
            btnAgendar.Click += btnAgendar_Click;
            // 
            // frmCadastraAgendamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 154, 87);
            ClientSize = new Size(1168, 721);
            Controls.Add(btnVoltar);
            Controls.Add(btnAgendar);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(cbxTosa);
            Controls.Add(cbxBanho);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(txtTelefone);
            Controls.Add(label4);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(lblAgendamento);
            Controls.Add(pictureBox1);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MaximumSize = new Size(1184, 760);
            MinimumSize = new Size(1184, 760);
            Name = "frmCadastraAgendamento";
            Text = "Novo Agendamento";
            FormClosed += frmCadastraAgendamento_FormClosed;
            Load += frmCadastraAgendamento_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblAgendamento;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox cbxBanho;
        private System.Windows.Forms.CheckBox cbxTosa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAgendar;
    }
}