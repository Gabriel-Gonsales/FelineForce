namespace ERP_com_relatorio
{
    partial class frmCadastroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroCliente));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            label3 = new Label();
            txtTelefone = new TextBox();
            label4 = new Label();
            btnSalvar = new Button();
            btnVoltar = new Button();
            txtEndereco = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 14);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(200, 62, 77);
            label1.Location = new Point(149, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(425, 52);
            label1.TabIndex = 8;
            label1.Text = "Cadastro do Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(200, 62, 77);
            label2.Location = new Point(103, 198);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(102, 38);
            label2.TabIndex = 9;
            label2.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNome.ForeColor = Color.FromArgb(200, 62, 77);
            txtNome.Location = new Point(111, 246);
            txtNome.Margin = new Padding(4, 3, 4, 3);
            txtNome.Name = "txtNome";
            txtNome.ShortcutsEnabled = false;
            txtNome.Size = new Size(372, 40);
            txtNome.TabIndex = 10;
            txtNome.WordWrap = false;
            txtNome.TextChanged += txtNome_TextChanged_1;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.FromArgb(200, 62, 77);
            txtEmail.Location = new Point(111, 357);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.ShortcutsEnabled = false;
            txtEmail.Size = new Size(372, 40);
            txtEmail.TabIndex = 12;
            txtEmail.WordWrap = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(200, 62, 77);
            label3.Location = new Point(103, 309);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 38);
            label3.TabIndex = 11;
            label3.Text = "Email";
            // 
            // txtTelefone
            // 
            txtTelefone.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTelefone.ForeColor = Color.FromArgb(200, 62, 77);
            txtTelefone.Location = new Point(666, 246);
            txtTelefone.Margin = new Padding(4, 3, 4, 3);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.ShortcutsEnabled = false;
            txtTelefone.Size = new Size(372, 40);
            txtTelefone.TabIndex = 14;
            txtTelefone.WordWrap = false;
            txtTelefone.TextChanged += txtTelefone_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(200, 62, 77);
            label4.Location = new Point(658, 198);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(145, 38);
            label4.TabIndex = 13;
            label4.Text = "Telefone";
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(200, 62, 77);
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(748, 642);
            btnSalvar.Margin = new Padding(0);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(120, 44);
            btnSalvar.TabIndex = 15;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(200, 62, 77);
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.ForeColor = Color.White;
            btnVoltar.Location = new Point(955, 642);
            btnVoltar.Margin = new Padding(0);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(120, 44);
            btnVoltar.TabIndex = 16;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // txtEndereco
            // 
            txtEndereco.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEndereco.ForeColor = Color.FromArgb(200, 62, 77);
            txtEndereco.Location = new Point(666, 357);
            txtEndereco.Margin = new Padding(4, 3, 4, 3);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.ShortcutsEnabled = false;
            txtEndereco.Size = new Size(372, 40);
            txtEndereco.TabIndex = 18;
            txtEndereco.WordWrap = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(200, 62, 77);
            label5.Location = new Point(658, 309);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(157, 38);
            label5.TabIndex = 17;
            label5.Text = "Endereço";
            // 
            // frmCadastroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 154, 87);
            ClientSize = new Size(1168, 721);
            Controls.Add(txtEndereco);
            Controls.Add(label5);
            Controls.Add(btnVoltar);
            Controls.Add(btnSalvar);
            Controls.Add(txtTelefone);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MaximumSize = new Size(1184, 760);
            MinimumSize = new Size(1184, 760);
            Name = "frmCadastroCliente";
            Text = "Cadastro de Cliente";
            FormClosed += frmCadastroCliente_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label5;
    }
}