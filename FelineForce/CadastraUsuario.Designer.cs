namespace ERP_com_relatorio
{
    partial class frmCadastraUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastraUsuario));
            txtHoras = new TextBox();
            label5 = new Label();
            txtSalario = new TextBox();
            label3 = new Label();
            txtNome = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            btnVoltar = new Button();
            btnSalvar = new Button();
            btnExcluir = new Button();
            btnResetarSenha = new Button();
            selecioneTipo = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // selecioneTipo
            // 
            selecioneTipo.ForeColor = Color.FromArgb(4, 113, 166);
            selecioneTipo.FormattingEnabled = true;
            selecioneTipo.Items.AddRange(new object[] { "Atendente", "Administrador", "Veterinário", "Tosador" });
            selecioneTipo.Location = new Point(701, 272);
            selecioneTipo.Name = "selecioneTipo";
            selecioneTipo.Size = new Size(372, 23);
            selecioneTipo.TabIndex = 45;
            selecioneTipo.Text = "Selecione";
            selecioneTipo.SelectedIndexChanged += selecioneTipo_SelectedIndexChanged_1;
            // 
            // txtHoras
            // 
            txtHoras.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtHoras.ForeColor = Color.FromArgb(4, 113, 166);
            txtHoras.Location = new Point(709, 147);
            txtHoras.Margin = new Padding(4, 3, 4, 3);
            txtHoras.Name = "txtHoras";
            txtHoras.ShortcutsEnabled = false;
            txtHoras.Size = new Size(372, 40);
            txtHoras.TabIndex = 28;
            txtHoras.WordWrap = false;
            txtHoras.TextChanged += txtHoras_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(4, 113, 166);
            label5.Location = new Point(701, 100);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(296, 38);
            label5.TabIndex = 27;
            label5.Text = "Horas Trabalhadas";
            label5.Click += label5_Click;
            // 
            // txtSalario
            // 
            txtSalario.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSalario.ForeColor = Color.FromArgb(4, 113, 166);
            txtSalario.Location = new Point(160, 257);
            txtSalario.Margin = new Padding(4, 3, 4, 3);
            txtSalario.Name = "txtSalario";
            txtSalario.ShortcutsEnabled = false;
            txtSalario.Size = new Size(372, 40);
            txtSalario.TabIndex = 24;
            txtSalario.WordWrap = false;
            txtSalario.TextChanged += txtSalario_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(4, 113, 166);
            label3.Location = new Point(152, 210);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(121, 38);
            label3.TabIndex = 23;
            label3.Text = "Salário";
            label3.Click += label3_Click;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNome.ForeColor = Color.FromArgb(4, 113, 166);
            txtNome.Location = new Point(160, 147);
            txtNome.Margin = new Padding(4, 3, 4, 3);
            txtNome.Name = "txtNome";
            txtNome.ShortcutsEnabled = false;
            txtNome.Size = new Size(372, 40);
            txtNome.TabIndex = 22;
            txtNome.WordWrap = false;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(4, 113, 166);
            label2.Location = new Point(152, 99);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(102, 38);
            label2.TabIndex = 21;
            label2.Text = "Nome";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(4, 113, 166);
            label1.Location = new Point(192, 23);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(438, 52);
            label1.TabIndex = 20;
            label1.Text = "Cadastro de Usuário";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(57, 5);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(4, 113, 166);
            label6.Location = new Point(701, 216);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(135, 38);
            label6.TabIndex = 29;
            label6.Text = "Acesso:";
            label6.Click += label6_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(4, 113, 166);
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.ForeColor = Color.White;
            btnVoltar.Location = new Point(961, 667);
            btnVoltar.Margin = new Padding(0);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(120, 44);
            btnVoltar.TabIndex = 40;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(4, 113, 166);
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(771, 667);
            btnSalvar.Margin = new Padding(0);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(120, 44);
            btnSalvar.TabIndex = 41;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.FromArgb(4, 113, 166);
            btnExcluir.FlatAppearance.BorderSize = 0;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.ForeColor = Color.White;
            btnExcluir.Location = new Point(555, 667);
            btnExcluir.Margin = new Padding(0);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(144, 44);
            btnExcluir.TabIndex = 42;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnResetarSenha
            // 
            btnResetarSenha.BackColor = Color.FromArgb(4, 113, 166);
            btnResetarSenha.FlatAppearance.BorderSize = 0;
            btnResetarSenha.FlatStyle = FlatStyle.Flat;
            btnResetarSenha.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResetarSenha.ForeColor = Color.White;
            btnResetarSenha.Location = new Point(252, 667);
            btnResetarSenha.Margin = new Padding(0);
            btnResetarSenha.Name = "btnResetarSenha";
            btnResetarSenha.Size = new Size(237, 44);
            btnResetarSenha.TabIndex = 43;
            btnResetarSenha.Text = "Resetar Senha";
            btnResetarSenha.UseVisualStyleBackColor = false;
            btnResetarSenha.Click += btnResetarSenha_Click;
            // 
            // frmCadastraUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 154, 87);
            ClientSize = new Size(1168, 721);
            Controls.Add(selecioneTipo);
            Controls.Add(txtHoras);
            Controls.Add(txtSalario);
            Controls.Add(btnResetarSenha);
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(btnVoltar);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MaximumSize = new Size(1184, 760);
            MinimumSize = new Size(1184, 760);
            Name = "frmCadastraUsuario";
            Text = "Cadastro de Usuario";
            Load += frmCadastraUsuario_Load;
            FormClosed += frmCadastraUsuario_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void FrmCadastraUsuario_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnResetarSenha;
        private ComboBox selecioneTipo;
    }
}