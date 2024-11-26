namespace ERP_com_relatorio
{
    partial class frmUsuarios
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
            btnEditar = new Button();
            btnCadastrar = new Button();
            btnExcluir = new Button();
            btnVoltar = new Button();
            grdUsuarios = new DataGridView();
            Check = new DataGridViewCheckBoxColumn();
            Usuario = new DataGridViewTextBoxColumn();
            Cargo = new DataGridViewTextBoxColumn();
            Salario = new DataGridViewTextBoxColumn();
            Horas = new DataGridViewTextBoxColumn();
            btnProcurar = new Button();
            txtPesquisa = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)grdUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(4, 113, 166);
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(690, 658);
            btnEditar.Margin = new Padding(0);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(131, 44);
            btnEditar.TabIndex = 30;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.FromArgb(4, 113, 166);
            btnCadastrar.FlatAppearance.BorderSize = 0;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = Color.White;
            btnCadastrar.Location = new Point(527, 658);
            btnCadastrar.Margin = new Padding(0);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(131, 44);
            btnCadastrar.TabIndex = 29;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.FromArgb(4, 113, 166);
            btnExcluir.FlatAppearance.BorderSize = 0;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.ForeColor = Color.White;
            btnExcluir.Location = new Point(849, 658);
            btnExcluir.Margin = new Padding(0);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(120, 44);
            btnExcluir.TabIndex = 28;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click_1;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(4, 113, 166);
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.ForeColor = Color.White;
            btnVoltar.Location = new Point(1007, 658);
            btnVoltar.Margin = new Padding(0);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(120, 44);
            btnVoltar.TabIndex = 27;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // grdUsuarios
            // 
            grdUsuarios.AllowUserToAddRows = false;
            grdUsuarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grdUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            grdUsuarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grdUsuarios.BackgroundColor = Color.FromArgb(4, 113, 166);
            grdUsuarios.BorderStyle = BorderStyle.Fixed3D;
            grdUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdUsuarios.Columns.AddRange(new DataGridViewColumn[] { Check, Usuario, Cargo, Salario, Horas });
            grdUsuarios.Location = new Point(82, 155);
            grdUsuarios.Margin = new Padding(4, 3, 4, 3);
            grdUsuarios.Name = "grdUsuarios";
            grdUsuarios.Size = new Size(1043, 472);
            grdUsuarios.TabIndex = 26;
            grdUsuarios.CellContentClick += grdUsuarios_CellContentClick;
            // 
            // Check
            // 
            Check.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Check.HeaderText = "";
            Check.MinimumWidth = 80;
            Check.Name = "Check";
            Check.Width = 80;
            // 
            // Usuario
            // 
            Usuario.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Usuario.HeaderText = "Usuário";
            Usuario.MinimumWidth = 180;
            Usuario.Name = "Usuario";
            Usuario.Width = 180;
            // 
            // Cargo
            // 
            Cargo.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Cargo.HeaderText = "Cargo";
            Cargo.MinimumWidth = 180;
            Cargo.Name = "Cargo";
            Cargo.Width = 180;
            // 
            // Salario
            // 
            Salario.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Salario.HeaderText = "Salário";
            Salario.MinimumWidth = 180;
            Salario.Name = "Salario";
            Salario.Width = 180;
            // 
            // Horas
            // 
            Horas.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Horas.HeaderText = "Horas Semanais";
            Horas.MinimumWidth = 230;
            Horas.Name = "Horas";
            Horas.Width = 230;
            // 
            // btnProcurar
            // 
            btnProcurar.BackColor = Color.FromArgb(4, 113, 166);
            btnProcurar.FlatAppearance.BorderSize = 0;
            btnProcurar.FlatStyle = FlatStyle.Flat;
            btnProcurar.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProcurar.ForeColor = Color.White;
            btnProcurar.Location = new Point(1001, 52);
            btnProcurar.Margin = new Padding(0);
            btnProcurar.Name = "btnProcurar";
            btnProcurar.Size = new Size(120, 44);
            btnProcurar.TabIndex = 25;
            btnProcurar.Text = "Procurar";
            btnProcurar.UseVisualStyleBackColor = false;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPesquisa.ForeColor = Color.FromArgb(4, 113, 166);
            txtPesquisa.Location = new Point(584, 52);
            txtPesquisa.Margin = new Padding(4, 3, 4, 3);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.ShortcutsEnabled = false;
            txtPesquisa.Size = new Size(372, 40);
            txtPesquisa.TabIndex = 24;
            txtPesquisa.WordWrap = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(4, 113, 166);
            label1.Location = new Point(176, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(202, 52);
            label1.TabIndex = 23;
            label1.Text = "Usuários";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(41, 20);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 154, 87);
            ClientSize = new Size(1168, 721);
            Controls.Add(btnEditar);
            Controls.Add(btnCadastrar);
            Controls.Add(btnExcluir);
            Controls.Add(btnVoltar);
            Controls.Add(grdUsuarios);
            Controls.Add(btnProcurar);
            Controls.Add(txtPesquisa);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MaximumSize = new Size(1184, 760);
            MinimumSize = new Size(1184, 760);
            Name = "frmUsuarios";
            Text = "Usuários do Sistema";
            FormClosed += frmUsuarios_FormClosed;
            ((System.ComponentModel.ISupportInitialize)grdUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridView grdUsuarios;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horas;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}