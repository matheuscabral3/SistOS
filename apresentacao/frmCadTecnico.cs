﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp1.apresentacao
{
    public partial class frmCadTecnico : Form
    {
        Thread th;
        conexao con = new conexao();
        frmMenu frmMenu = new frmMenu();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr = null;
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public string mensagem = "";
        private string mstrNome = "";
        private string mstrRG = "";
        bool tem = false;



        public frmCadTecnico()
        {
            InitializeComponent();
        }


        //MÉTODO PARA INCLUIR
        //---------------------------------
        private void btnCadastrarTec_Click(object sender, EventArgs e)
        {
            this.mensagem = "";

            //VALIDAR CONTROLES
            ValidarControles();
            if (this.mensagem.Length > 0)
            {
                MessageBox.Show(mensagem, "Erro ao Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //VALIDAR TECNICOS JÁ CADASTRADOS
            bool validar = verificarTecnico(txbNome.Text);
            if (validar == true)
            {
                MessageBox.Show(mensagem, "Erro ao Cadastrar.", MessageBoxButtons.OK);
                return;
            }


            cmd.CommandText = "INSERT INTO tbTecnicos(nome_tecnico, telefone, email, cidade, endereco, bairro, cargo, CPF, RG)" +
            "VALUES(@nome, @telefone, @email, @cidade, @endereco, @bairro, @cargo, @CPF, @RG);";

            cmd.Parameters.AddWithValue("@nome_tecnico", this.txbNome.Text);
            cmd.Parameters.AddWithValue("@telefone", this.txbTEL.Text);
            cmd.Parameters.AddWithValue("@email", this.txbEmail.Text);
            cmd.Parameters.AddWithValue("@cidade", this.txbCidade.Text);
            cmd.Parameters.AddWithValue("@endereco", this.txbEnd.Text);
            cmd.Parameters.AddWithValue("@bairro", this.txbBairro.Text);
            cmd.Parameters.AddWithValue("@cargo", this.txbCargo.Text);
            cmd.Parameters.AddWithValue("@CPF", this.txbCPF.Text);
            cmd.Parameters.AddWithValue("@RG", this.txbRG.Text);

            //Executar
            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();
                this.mensagem = "Tecnico Cadastrado com Sucesso.";
                MessageBox.Show(mensagem, "Cadastro Realizado.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetForm();
                limpaDataGrid();
                return;

            }
            catch (SqlException)
            {
                this.mensagem = "Erro ao Cadastrar Tecnico no banco, verifique as informações.";
                MessageBox.Show(mensagem, "Erro Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }


        //MÉTODO PARA RESETAR FORMULARIO
        //---------------------------------
        private void resetForm()
        {
            txbBairro.Text = "";
            txbCargo.Text = "Tecnico";
            txbCidade.Text = "";
            txbCPF.Text = "";
            txbEmail.Text = "";
            txbEnd.Text = "";
            txbNome.Text = "";
            txbRG.Text = "";
            txbTEL.Text = "";
            return;
        }


        //MÉTODO PARA VOLTAR
        //---------------------------------
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            // th = new Thread(openformMenu);
            // th.SetApartmentState(ApartmentState.STA);
            // th.Start();
        }


        //MÉTODO LOAD
        //---------------------------------
        private void fmrCadTecnico_Load(object sender, EventArgs e)
        {
            txbCargo.Text = "Tecnico";
            txbCargo.Enabled = false;
        }


        //MÉTODO PARA VALIDAR CONTROLES
        //---------------------------------
        private void ValidarControles()
        {
            if (txbNome.Text == "" || txbEmail.Text == "" || txbCidade.Text == "" || txbEnd.Text == "" || txbTEL.Text == "" || txbBairro.Text == "" || txbCargo.Text == "" || txbCPF.Text == "" || txbRG.Text == "")
            {
                this.mensagem = "Preencha todos os campos.";
            }
            return;
        }

        private void openformMenu()
        {
            Application.Run(new frmMenu());
        }


        //MÉTODO PARA EXCLUIR
        //---------------------------------
        private void btnExcluir_Click(object sender, EventArgs e)
        {

            cmd.CommandText = "DELETE FROM tbTecnicos WHERE nome_tecnico = @nome AND RG = @RG;";


            cmd.Parameters.AddWithValue("@nome_tecnico", this.txbNome.Text);
            cmd.Parameters.AddWithValue("@RG", this.txbRG.Text);

            //Executar
            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();
                this.mensagem = "Tecnico Excluido com Sucesso.";
                MessageBox.Show(mensagem, "Exclusão Realizada.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetForm();
                limpaDataGrid();
                return;

            }
            catch (SqlException)
            {
                this.mensagem = "Erro ao Excluir Tecnico no banco, verifique as informações.";
                MessageBox.Show(mensagem, "Erro Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }


        //MÉTODO PARA CONSULTAR
        //---------------------------------
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txbNome.Text == "")
            {
                ConsultarTodos();
                return;
            }

            try
            {
                string strSQL = "SELECT * FROM tbTecnicos WHERE nome_tecnico LIKE '%" + txbNome.Text + "%';";
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();  //Pegar a informação e guardar em algum lugar ? ==> dr;
                cmd = new SqlCommand(strSQL, con.conectar());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dtTecnicos.DataSource = dt;

                dr.Close();
            }
            catch (SqlException)
            {
                this.mensagem = "Erro ao consultar Tecnico no banco !"; //Mensagem de Erro
            }
            if (mensagem != "")
            {
                MessageBox.Show(mensagem, "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        //MÉTODO PARA CONSULTAR TODOS
        //---------------------------------
        private void ConsultarTodos()
        {
            if (da != null)
            {
                da = null;
            }
            try
            {
                //limpaDatagrid();
                string strSQL = "SELECT * FROM tbTecnicos";
                cmd = new SqlCommand(strSQL, con.conectar());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dtTecnicos.DataSource = dt;
                //configuraDataGrid();
            }
            catch
            {
                this.mensagem = "Erro ao Consultar todos os Tecnicos !";
            }
        }



        //MÉTODO PARA VERIFICAR CLIENTE EXISTENTE
        //---------------------------------
        public bool verificarTecnico(string nome)//Verificar no Banco de Dados, se possui valor com esse parâmetro
        {
            try
            {

                if (nome != "")
                {
                    //VERIFICAÇÃO DE INCLUSÃO - SELECT > INSERT
                    cmd.CommandText = "SELECT * FROM tbTecnicos WHERE nome_tecnico ='" + nome + "'; ";
                }

                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();  //Pegar a informação e guardar em algum lugar ? ==> dr;
                if (dr.HasRows)  //se foi encontrado
                {
                    this.mensagem = "Este Cliente já existe.";
                    tem = true;
                }
                con.desconectar();
                dr.Close();
            }
            catch (SqlException)
            {
                tem = false;
            }

            return tem;
        }


        //MÉTODO PARA LIMPAR A TABELA
        //---------------------------------
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpaDataGrid();
            resetForm();
            return;
        }

        //MÉTODO PARA LIMPAR A TABELA
        //---------------------------------
        private void limpaDataGrid()
        {
            if (dtTecnicos.DataSource != null)
            {
                int numRows = dtTecnicos.Rows.Count;
                for (int i = 0; i < numRows; i++)
                {
                    try
                    {
                        int max = dtTecnicos.Rows.Count - 1;
                        dtTecnicos.Rows.Remove(dtTecnicos.Rows[max]);

                    }
                    catch (Exception exe)
                    {
                        MessageBox.Show("Erro ao Limpar Tabela" + exe, "WTF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
            dtTecnicos.DataSource = null;
            dtTecnicos.Refresh();
            return;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //VALIDAR LÓGICA DE ALTERAÇÃO
            cmd.CommandText = "UPDATE tbTecnicos SET nome_tecnico = @nome_tecnico, telefone = @telefone, email = @email, cidade = @cidade,  endereco = @endereco, " +
            " bairro = @bairro, cargo = @cargo,  CPF = @CPF, RG = @RG " +
            " WHERE nome_tecnico = '" + mstrNome + "' AND RG = '" + mstrRG + "';";

            cmd.Parameters.AddWithValue("@nome_tecnico", this.txbNome.Text);
            cmd.Parameters.AddWithValue("@telefone", this.txbTEL.Text);
            cmd.Parameters.AddWithValue("@email", this.txbEmail.Text);
            cmd.Parameters.AddWithValue("@cidade", this.txbCidade.Text);
            cmd.Parameters.AddWithValue("@endereco", this.txbEnd.Text);
            cmd.Parameters.AddWithValue("@bairro", this.txbBairro.Text);
            cmd.Parameters.AddWithValue("@cargo", this.txbCargo.Text);
            cmd.Parameters.AddWithValue("@CPF", this.txbCPF.Text);
            cmd.Parameters.AddWithValue("@RG", this.txbRG.Text);

            //Executar
            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();
                this.mensagem = "Técnico Alterado com Sucesso.";
                MessageBox.Show(mensagem, "Alteração Concluída.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetForm();
                limpaDataGrid();
                return;

            }
            catch (SqlException)
            {
                this.mensagem = "Erro ao Alterar Técnico no banco, verifique as informações.";
                MessageBox.Show(mensagem, "Erro Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void dtTecnicos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //LÓGICA (Obter o DataGrid > Selecionar a Coluna > Preencher a TextBox)
            //Obter o conteúdo da Linha selecionado.
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtTecnicos.Rows[e.RowIndex];
                txbNome.Text = row.Cells["nome_tecnico"].Value.ToString();
                txbTEL.Text = row.Cells["telefone"].Value.ToString();
                txbEmail.Text = row.Cells["email"].Value.ToString();
                txbCidade.Text = row.Cells["cidade"].Value.ToString();
                txbEnd.Text = row.Cells["endereco"].Value.ToString();
                txbBairro.Text = row.Cells["bairro"].Value.ToString();
                txbCargo.Text = row.Cells["cargo"].Value.ToString();
                txbCPF.Text = row.Cells["CPF"].Value.ToString();
                txbRG.Text = row.Cells["RG"].Value.ToString();
            }
            mstrNome = txbNome.Text;
            mstrRG = txbRG.Text;

        }
    }
}
