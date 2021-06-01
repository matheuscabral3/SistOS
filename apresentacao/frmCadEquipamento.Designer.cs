namespace WindowsFormsApp1.apresentacao
{
    partial class frmCadEquipamento
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbNomeEquip = new System.Windows.Forms.TextBox();
            this.txbModelo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbValor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCadEquip = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txbEstoqueDisp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dtEquipamentos = new System.Windows.Forms.DataGridView();
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtEquipamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Equipamento:";
            // 
            // txbNomeEquip
            // 
            this.txbNomeEquip.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbNomeEquip.Location = new System.Drawing.Point(72, 63);
            this.txbNomeEquip.Name = "txbNomeEquip";
            this.txbNomeEquip.Size = new System.Drawing.Size(249, 20);
            this.txbNomeEquip.TabIndex = 1;
            // 
            // txbModelo
            // 
            this.txbModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbModelo.Location = new System.Drawing.Point(341, 63);
            this.txbModelo.Name = "txbModelo";
            this.txbModelo.Size = new System.Drawing.Size(249, 20);
            this.txbModelo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(338, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo:";
            // 
            // txbValor
            // 
            this.txbValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbValor.Location = new System.Drawing.Point(72, 118);
            this.txbValor.MaxLength = 10;
            this.txbValor.Name = "txbValor";
            this.txbValor.Size = new System.Drawing.Size(249, 20);
            this.txbValor.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor Peça:";
            // 
            // btnCadEquip
            // 
            this.btnCadEquip.Location = new System.Drawing.Point(207, 181);
            this.btnCadEquip.Name = "btnCadEquip";
            this.btnCadEquip.Size = new System.Drawing.Size(90, 30);
            this.btnCadEquip.TabIndex = 6;
            this.btnCadEquip.Text = "Incluir";
            this.btnCadEquip.UseVisualStyleBackColor = true;
            this.btnCadEquip.Click += new System.EventHandler(this.btnCadEquip_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(384, 406);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(90, 30);
            this.btnVoltar.TabIndex = 7;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txbEstoqueDisp
            // 
            this.txbEstoqueDisp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbEstoqueDisp.Location = new System.Drawing.Point(341, 118);
            this.txbEstoqueDisp.Name = "txbEstoqueDisp";
            this.txbEstoqueDisp.Size = new System.Drawing.Size(249, 20);
            this.txbEstoqueDisp.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(338, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Estoque Disponível:";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(359, 181);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(90, 30);
            this.btnAlterar.TabIndex = 10;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click_1);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(500, 181);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(90, 30);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(72, 181);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(90, 30);
            this.btnConsultar.TabIndex = 12;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dtEquipamentos
            // 
            this.dtEquipamentos.AllowUserToAddRows = false;
            this.dtEquipamentos.AllowUserToDeleteRows = false;
            this.dtEquipamentos.AllowUserToResizeColumns = false;
            this.dtEquipamentos.AllowUserToResizeRows = false;
            this.dtEquipamentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtEquipamentos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtEquipamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtEquipamentos.Location = new System.Drawing.Point(59, 226);
            this.dtEquipamentos.Margin = new System.Windows.Forms.Padding(2);
            this.dtEquipamentos.MultiSelect = false;
            this.dtEquipamentos.Name = "dtEquipamentos";
            this.dtEquipamentos.ReadOnly = true;
            this.dtEquipamentos.RowHeadersWidth = 51;
            this.dtEquipamentos.RowTemplate.Height = 24;
            this.dtEquipamentos.Size = new System.Drawing.Size(553, 156);
            this.dtEquipamentos.TabIndex = 13;
            this.dtEquipamentos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtEquipamentos_CellContentClick);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(175, 406);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(90, 30);
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.Text = "Limpar Tabela";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmCadEquipamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(671, 448);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.dtEquipamentos);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.txbEstoqueDisp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCadEquip);
            this.Controls.Add(this.txbValor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbModelo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbNomeEquip);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCadEquipamento";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Equipamentos";
            this.Load += new System.EventHandler(this.fmrCadEquipamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtEquipamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNomeEquip;
        private System.Windows.Forms.TextBox txbModelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbValor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCadEquip;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txbEstoqueDisp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dtEquipamentos;
        private System.Windows.Forms.Button btnLimpar;
    }
}