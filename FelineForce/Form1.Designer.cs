namespace ERP_com_relatorio
{
    partial class frmLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            txtLogin = new TextBox();
            txtSenha = new TextBox();
            btnLogar = new Button();
            pictureBox1 = new PictureBox();
            lblEsqueceu = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtLogin
            // 
            txtLogin.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtLogin.ForeColor = Color.FromArgb(200, 62, 77);
            txtLogin.Location = new Point(393, 314);
            txtLogin.Margin = new Padding(4, 3, 4, 3);
            txtLogin.Name = "txtLogin";
            txtLogin.ShortcutsEnabled = false;
            txtLogin.Size = new Size(372, 40);
            txtLogin.TabIndex = 0;
            txtLogin.WordWrap = false;
            txtLogin.TextChanged += txtLogin_TextChanged;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSenha.ForeColor = Color.FromArgb(200, 62, 77);
            txtSenha.Location = new Point(393, 402);
            txtSenha.Margin = new Padding(4, 3, 4, 3);
            txtSenha.Name = "txtSenha";
            txtSenha.ShortcutsEnabled = false;
            txtSenha.Size = new Size(372, 40);
            txtSenha.TabIndex = 1;
            txtSenha.UseSystemPasswordChar = true;
            txtSenha.WordWrap = false;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // btnLogar
            // 
            btnLogar.BackColor = Color.FromArgb(223, 154, 87);
            btnLogar.FlatStyle = FlatStyle.Flat;
            btnLogar.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogar.ForeColor = Color.White;
            btnLogar.Location = new Point(492, 526);
            btnLogar.Margin = new Padding(0);
            btnLogar.Name = "btnLogar";
            btnLogar.Size = new Size(173, 51);
            btnLogar.TabIndex = 0;
            btnLogar.Text = "Login";
            btnLogar.UseVisualStyleBackColor = false;
            btnLogar.Click += btnLogar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(451, 51);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(261, 203);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // lblEsqueceu
            // 
            lblEsqueceu.AutoSize = true;
            lblEsqueceu.Cursor = Cursors.Hand;
            lblEsqueceu.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblEsqueceu.ForeColor = Color.FromArgb(223, 154, 87);
            lblEsqueceu.Location = new Point(460, 467);
            lblEsqueceu.Margin = new Padding(4, 0, 4, 0);
            lblEsqueceu.Name = "lblEsqueceu";
            lblEsqueceu.Size = new Size(204, 24);
            lblEsqueceu.TabIndex = 7;
            lblEsqueceu.Text = "Esqueceu sua senha ?";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(200, 62, 77);
            ClientSize = new Size(1168, 721);
            Controls.Add(lblEsqueceu);
            Controls.Add(pictureBox1);
            Controls.Add(btnLogar);
            Controls.Add(txtSenha);
            Controls.Add(txtLogin);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MaximumSize = new Size(1184, 760);
            MinimumSize = new Size(1184, 760);
            Name = "frmLogin";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Login";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnLogar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblEsqueceu;
    }
}

