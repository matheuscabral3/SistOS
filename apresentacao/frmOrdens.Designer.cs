namespace WindowsFormsApp1.apresentacao
{
    partial class frmOrdens
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
            this.components = new System.ComponentModel.Container();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbNomeCliente = new System.Windows.Forms.TextBox();
            this.txbEquip = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNomeTec = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txbObs = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbDataEntrada = new System.Windows.Forms.MaskedTextBox();
            this.txbOrcamento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txbSituacao = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(110, 328);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(90, 30);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar O.S";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(265, 328);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(90, 30);
            this.btnImprimir.TabIndex = 1;
            this.btnImprimir.Text = "Imprimir O.S";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome Cliente:";
            // 
            // txbNomeCliente
            // 
            this.txbNomeCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbNomeCliente.Location = new System.Drawing.Point(100, 33);
            this.txbNomeCliente.Name = "txbNomeCliente";
            this.txbNomeCliente.Size = new System.Drawing.Size(198, 20);
            this.txbNomeCliente.TabIndex = 3;
            // 
            // txbEquip
            // 
            this.txbEquip.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbEquip.Location = new System.Drawing.Point(411, 33);
            this.txbEquip.Name = "txbEquip";
            this.txbEquip.Size = new System.Drawing.Size(217, 20);
            this.txbEquip.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(304, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Equipamento:";
            // 
            // txbNomeTec
            // 
            this.txbNomeTec.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbNomeTec.Location = new System.Drawing.Point(100, 80);
            this.txbNomeTec.Name = "txbNomeTec";
            this.txbNomeTec.Size = new System.Drawing.Size(198, 20);
            this.txbNomeTec.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nome Técnico:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(304, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Data de Entrada:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txbObs
            // 
            this.txbObs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbObs.Location = new System.Drawing.Point(25, 143);
            this.txbObs.Multiline = true;
            this.txbObs.Name = "txbObs";
            this.txbObs.Size = new System.Drawing.Size(603, 66);
            this.txbObs.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(264, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Defeito / Motivo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Orçamento R$:";
            // 
            // txbDataEntrada
            // 
            this.txbDataEntrada.Location = new System.Drawing.Point(412, 79);
            this.txbDataEntrada.Mask = "00/00/0000";
            this.txbDataEntrada.Name = "txbDataEntrada";
            this.txbDataEntrada.Size = new System.Drawing.Size(87, 20);
            this.txbDataEntrada.TabIndex = 15;
            this.txbDataEntrada.ValidatingType = typeof(System.DateTime);
            // 
            // txbOrcamento
            // 
            this.txbOrcamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbOrcamento.Location = new System.Drawing.Point(100, 232);
            this.txbOrcamento.Name = "txbOrcamento";
            this.txbOrcamento.Size = new System.Drawing.Size(118, 20);
            this.txbOrcamento.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(178, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Assinatura Técnico:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(315, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(247, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "________________________________________";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(422, 328);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(90, 30);
            this.btnVoltar.TabIndex = 19;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txbSituacao
            // 
            this.txbSituacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbSituacao.Location = new System.Drawing.Point(473, 232);
            this.txbSituacao.Name = "txbSituacao";
            this.txbSituacao.Size = new System.Drawing.Size(152, 20);
            this.txbSituacao.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(409, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "Situação:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // frmOrdens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(639, 374);
            this.Controls.Add(this.txbSituacao);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbOrcamento);
            this.Controls.Add(this.txbDataEntrada);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbObs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbNomeTec);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbEquip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbNomeCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmOrdens";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordem de Serviço";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNomeCliente;
        private System.Windows.Forms.TextBox txbEquip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNomeTec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txbObs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txbDataEntrada;
        private System.Windows.Forms.TextBox txbOrcamento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txbSituacao;
        private System.Windows.Forms.Label label9;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}