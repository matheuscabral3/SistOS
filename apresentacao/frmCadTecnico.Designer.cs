namespace WindowsFormsApp1.apresentacao
{
    partial class frmCadTecnico
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
            this.btnCadastrarTec = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbCidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbEnd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txbBairro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txbCargo = new System.Windows.Forms.TextBox();
            this.txbRG = new System.Windows.Forms.TextBox();
            this.dtTecnicos = new System.Windows.Forms.DataGridView();
            this.txbCPF = new System.Windows.Forms.TextBox();
            this.txbTEL = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtTecnicos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastrarTec
            // 
            this.btnCadastrarTec.Location = new System.Drawing.Point(29, 251);
            this.btnCadastrarTec.Name = "btnCadastrarTec";
            this.btnCadastrarTec.Size = new System.Drawing.Size(90, 30);
            this.btnCadastrarTec.TabIndex = 20;
            this.btnCadastrarTec.Text = "Incluir";
            this.btnCadastrarTec.UseVisualStyleBackColor = true;
            this.btnCadastrarTec.Click += new System.EventHandler(this.btnCadastrarTec_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nome:";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(33, 38);
            this.txbNome.MaxLength = 50;
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(279, 20);
            this.txbNome.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(350, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Telefone / Celular";
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(33, 93);
            this.txbEmail.MaxLength = 50;
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(279, 20);
            this.txbEmail.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "Email:";
            // 
            // txbCidade
            // 
            this.txbCidade.Location = new System.Drawing.Point(353, 93);
            this.txbCidade.MaxLength = 50;
            this.txbCidade.Name = "txbCidade";
            this.txbCidade.Size = new System.Drawing.Size(219, 20);
            this.txbCidade.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(350, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "Cidade:";
            // 
            // txbEnd
            // 
            this.txbEnd.Location = new System.Drawing.Point(33, 153);
            this.txbEnd.MaxLength = 50;
            this.txbEnd.Name = "txbEnd";
            this.txbEnd.Size = new System.Drawing.Size(279, 20);
            this.txbEnd.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 29;
            this.label5.Text = "Endereço:";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(482, 251);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(90, 30);
            this.btnVoltar.TabIndex = 31;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txbBairro
            // 
            this.txbBairro.Location = new System.Drawing.Point(353, 153);
            this.txbBairro.MaxLength = 50;
            this.txbBairro.Name = "txbBairro";
            this.txbBairro.Size = new System.Drawing.Size(219, 20);
            this.txbBairro.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(350, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 32;
            this.label6.Text = "Bairro:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(240, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 15);
            this.label7.TabIndex = 34;
            this.label7.Text = "CPF:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 15);
            this.label8.TabIndex = 36;
            this.label8.Text = "Cargo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(421, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 15);
            this.label9.TabIndex = 38;
            this.label9.Text = "RG:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(126, 251);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(90, 30);
            this.btnConsultar.TabIndex = 40;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(222, 251);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(90, 30);
            this.btnAlterar.TabIndex = 41;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(318, 251);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(90, 30);
            this.btnExcluir.TabIndex = 42;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txbCargo
            // 
            this.txbCargo.Location = new System.Drawing.Point(33, 211);
            this.txbCargo.MaxLength = 50;
            this.txbCargo.Name = "txbCargo";
            this.txbCargo.Size = new System.Drawing.Size(187, 20);
            this.txbCargo.TabIndex = 43;
            // 
            // txbRG
            // 
            this.txbRG.Location = new System.Drawing.Point(419, 211);
            this.txbRG.MaxLength = 11;
            this.txbRG.Name = "txbRG";
            this.txbRG.Size = new System.Drawing.Size(153, 20);
            this.txbRG.TabIndex = 45;
            // 
            // dtTecnicos
            // 
            this.dtTecnicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtTecnicos.Location = new System.Drawing.Point(33, 297);
            this.dtTecnicos.Name = "dtTecnicos";
            this.dtTecnicos.Size = new System.Drawing.Size(537, 121);
            this.dtTecnicos.TabIndex = 49;
            // 
            // txbCPF
            // 
            this.txbCPF.Location = new System.Drawing.Point(243, 211);
            this.txbCPF.MaxLength = 14;
            this.txbCPF.Name = "txbCPF";
            this.txbCPF.Size = new System.Drawing.Size(153, 20);
            this.txbCPF.TabIndex = 50;
            // 
            // txbTEL
            // 
            this.txbTEL.Location = new System.Drawing.Point(353, 38);
            this.txbTEL.MaxLength = 11;
            this.txbTEL.Name = "txbTEL";
            this.txbTEL.Size = new System.Drawing.Size(217, 20);
            this.txbTEL.TabIndex = 51;
            // 
            // frmCadTecnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(594, 437);
            this.Controls.Add(this.txbTEL);
            this.Controls.Add(this.txbCPF);
            this.Controls.Add(this.dtTecnicos);
            this.Controls.Add(this.txbRG);
            this.Controls.Add(this.txbCargo);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbBairro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.txbEnd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbCidade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadastrarTec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCadTecnico";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Tecnicos";
            this.Load += new System.EventHandler(this.fmrCadTecnico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtTecnicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCadastrarTec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbCidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbEnd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txbBairro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox txbCargo;
        private System.Windows.Forms.TextBox txbRG;
        private System.Windows.Forms.DataGridView dtTecnicos;
        private System.Windows.Forms.TextBox txbCPF;
        private System.Windows.Forms.TextBox txbTEL;
    }
}