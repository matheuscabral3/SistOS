namespace WindowsFormsApp1.apresentacao
{
    partial class frmPerfil
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
            this.dtPerfil = new System.Windows.Forms.DataGridView();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.btnConsultarTodos = new System.Windows.Forms.Button();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.cboPermissao = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbConfSenha = new System.Windows.Forms.TextBox();
            this.exemploDataSet1 = new WindowsFormsApp1.RATBANCODataSet1();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exemploDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtPerfil
            // 
            this.dtPerfil.AllowUserToAddRows = false;
            this.dtPerfil.AllowUserToDeleteRows = false;
            this.dtPerfil.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtPerfil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtPerfil.GridColor = System.Drawing.SystemColors.Control;
            this.dtPerfil.Location = new System.Drawing.Point(16, 276);
            this.dtPerfil.Name = "dtPerfil";
            this.dtPerfil.ReadOnly = true;
            this.dtPerfil.Size = new System.Drawing.Size(349, 106);
            this.dtPerfil.TabIndex = 0;
            this.dtPerfil.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgPerfil_CellContentClick);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Location = new System.Drawing.Point(384, 344);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(108, 25);
            this.btnDesconectar.TabIndex = 4;
            this.btnDesconectar.Text = "Voltar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // btnConsultarTodos
            // 
            this.btnConsultarTodos.Location = new System.Drawing.Point(64, 388);
            this.btnConsultarTodos.Name = "btnConsultarTodos";
            this.btnConsultarTodos.Size = new System.Drawing.Size(196, 25);
            this.btnConsultarTodos.TabIndex = 5;
            this.btnConsultarTodos.Text = "Listar Todos os Usuários Cadastrados";
            this.btnConsultarTodos.UseVisualStyleBackColor = true;
            this.btnConsultarTodos.Click += new System.EventHandler(this.btnConsultarTodos_Click);
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(208, 63);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(193, 20);
            this.txbEmail.TabIndex = 6;
            this.txbEmail.TextChanged += new System.EventHandler(this.txbEmail_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Consultar dados do usuário";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(422, 111);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 10;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(384, 306);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(108, 23);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar Tabela";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Castellar", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "R.A.T.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.gerente;
            this.pictureBox1.Location = new System.Drawing.Point(16, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(208, 111);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(193, 20);
            this.txbSenha.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Email / Usuário";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Senha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Permissão";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Selecione o usuário desejado:";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(422, 63);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 20;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(422, 160);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 21;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // cboPermissao
            // 
            this.cboPermissao.FormattingEnabled = true;
            this.cboPermissao.Items.AddRange(new object[] {
            "1 - Gerente",
            "2 - Funcionário"});
            this.cboPermissao.Location = new System.Drawing.Point(208, 208);
            this.cboPermissao.Name = "cboPermissao";
            this.cboPermissao.Size = new System.Drawing.Size(193, 21);
            this.cboPermissao.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(205, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Confirmar Senha";
            // 
            // txbConfSenha
            // 
            this.txbConfSenha.Location = new System.Drawing.Point(208, 162);
            this.txbConfSenha.Name = "txbConfSenha";
            this.txbConfSenha.Size = new System.Drawing.Size(193, 20);
            this.txbConfSenha.TabIndex = 23;
            // 
            // exemploDataSet1
            // 
            this.exemploDataSet1.DataSetName = "exemploDataSet1";
            this.exemploDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(422, 206);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 25;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // frmPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(504, 425);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbConfSenha);
            this.Controls.Add(this.cboPermissao);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.btnConsultarTodos);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.dtPerfil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPerfil";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perfil";
            this.Load += new System.EventHandler(this.fmrEditarPerfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exemploDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtPerfil;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Button btnConsultarTodos;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.ComboBox cboPermissao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbConfSenha;
        private RATBANCODataSet1 exemploDataSet1;
        private System.Windows.Forms.Button btnExcluir;
    }
}