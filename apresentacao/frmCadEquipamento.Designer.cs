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
            this.txbPreco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCadEquip = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txbEstoqueDisp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Equipamento:";
            // 
            // txbNomeEquip
            // 
            this.txbNomeEquip.Location = new System.Drawing.Point(12, 37);
            this.txbNomeEquip.Name = "txbNomeEquip";
            this.txbNomeEquip.Size = new System.Drawing.Size(249, 20);
            this.txbNomeEquip.TabIndex = 1;
            // 
            // txbModelo
            // 
            this.txbModelo.Location = new System.Drawing.Point(281, 37);
            this.txbModelo.Name = "txbModelo";
            this.txbModelo.Size = new System.Drawing.Size(249, 20);
            this.txbModelo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(278, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo:";
            // 
            // txbPreco
            // 
            this.txbPreco.Location = new System.Drawing.Point(12, 92);
            this.txbPreco.Name = "txbPreco";
            this.txbPreco.Size = new System.Drawing.Size(249, 20);
            this.txbPreco.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor Peça:";
            // 
            // btnCadEquip
            // 
            this.btnCadEquip.Location = new System.Drawing.Point(116, 132);
            this.btnCadEquip.Name = "btnCadEquip";
            this.btnCadEquip.Size = new System.Drawing.Size(95, 27);
            this.btnCadEquip.TabIndex = 6;
            this.btnCadEquip.Text = "Incluir";
            this.btnCadEquip.UseVisualStyleBackColor = true;
            this.btnCadEquip.Click += new System.EventHandler(this.btnCadEquip_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(419, 132);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(95, 28);
            this.btnVoltar.TabIndex = 7;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txbEstoqueDisp
            // 
            this.txbEstoqueDisp.Location = new System.Drawing.Point(281, 92);
            this.txbEstoqueDisp.Name = "txbEstoqueDisp";
            this.txbEstoqueDisp.Size = new System.Drawing.Size(249, 20);
            this.txbEstoqueDisp.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(278, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Estoque Disponível:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(217, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 27);
            this.button1.TabIndex = 10;
            this.button1.Text = "Alterar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(318, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 27);
            this.button2.TabIndex = 11;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(15, 132);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(95, 27);
            this.btnConsultar.TabIndex = 12;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // frmCadEquipamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(547, 179);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbEstoqueDisp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCadEquip);
            this.Controls.Add(this.txbPreco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbModelo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbNomeEquip);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCadEquipamento";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Equipamento";
            this.Load += new System.EventHandler(this.fmrCadEquipamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNomeEquip;
        private System.Windows.Forms.TextBox txbModelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbPreco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCadEquip;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txbEstoqueDisp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnConsultar;
    }
}