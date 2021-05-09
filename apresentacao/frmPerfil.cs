﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;
using WindowsFormsApp1.dal;

namespace WindowsFormsApp1.apresentacao
{
    public partial class frmPerfil : Form
    {
        Thread th;
        LoginDaoComandos loginDao = new LoginDaoComandos();
        frmMenu frmMenu = new frmMenu();
        conexao con = new conexao();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr = null;
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter();
        public string mensagem = "";
        public string senhaAntiga = "";
        public string permissao = "";
        public int aux;

        public frmPerfil()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbEmail.TextLength > 0)
                {
                    limpaDatagrid();
                    string strSQL = "SELECT * FROM tbUsuarios WHERE LIKE '%" + txbEmail.Text + "%';";
                    // con.conectar();
                    cmd = new SqlCommand(strSQL, con.conectar());
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dtPerfil.DataSource = dt;
                    configuraDataGrid();
                    con.desconectar();
                }

                if (txbEmail.Text == "" && txbSenha.Text == "")
                {
                    btnConsultarTodos();
                    return;
                }
                else
                {
                    MessageBox.Show("Erro ao Consultar, Verifique o usuário.");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Erro ao Preencher a Tabela !");
            }
        }

        //Método listar o data grid view
        private void btnConsultarTodos()
        {
            if (da != null)
            {
                da = null;
            }
            try
            {
                limpaDatagrid();
                string strSQL = "SELECT * FROM tbUsuarios";
                // con.conectar();
                cmd = new SqlCommand(strSQL, con.conectar());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dtPerfil.DataSource = dt;
                configuraDataGrid();
                con.desconectar();
            }
            catch
            {
                MessageBox.Show("Erro ao Preencher a Tabela !");
            }
        }

        private void dvgPerfil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //LÓGICA (Obter o DataGrid > Selecionar a Coluna > Preencher a TextBox)
            //Obter o conteúdo da Linha selecionado.
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtPerfil.Rows[e.RowIndex];
                txbEmail.Text = row.Cells["usuarios"].Value.ToString();
                txbSenha.Text = row.Cells["senha"].Value.ToString();

                //armazena a senha para ser usada como identificado para realizar alterações no usuário.
                senhaAntiga = txbSenha.Text;

                //Lógica para alterar a combo.
                string permissao = row.Cells["permissao"].Value.ToString();
                if (permissao == "1")
                {
                    cboPermissao.SelectedIndex = 0;
                }
                if (permissao == "2")
                {
                    cboPermissao.SelectedIndex = 1;
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpaDatagrid();
            resetForm();
        }

        private void limpaDatagrid()
        {
            if (dtPerfil.DataSource != null)
            {
                dtPerfil.DataSource = null;
            }
            if (da != null)
            {
                da = null;
            }
        }

        private void configuraDataGrid()
        {

            ////OBRIGATÓRIO - CONFIGURA O HEADER
            dtPerfil.Columns[0].HeaderText = "Usuários";
            dtPerfil.Columns[1].HeaderText = "Senha";
            dtPerfil.Columns[2].HeaderText = "Permissão";

            // OPCIONAL - Ajuste das Colunas.
            dtPerfil.Columns[0].Width = 165;
            dtPerfil.Columns[1].Width = 165;
            dtPerfil.Columns[2].Width = 160;

            //OPCIONAL - Exibir Colunas não visíveis.
            // dtPerfil.Columns[0].Visible = false;
            //dtPerfil.Columns[1].Visible = false;
            //dtPerfil.Columns[2].Visible = false;

            return;
        }

        private void fmrEditarPerfil_Load(object sender, EventArgs e)
        {
            limpaDatagrid();
            resetForm();
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openformMenu);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openformMenu()
        {
            Application.Run(new frmMenu());
        }

        private void txbEmail_TextChanged_1(object sender, EventArgs e)
        {
            txbSenha.Text = "";
            //cboPermissao.SelectedIndex = cboPermissao.SelectedIndex;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {

            ValidarForm();

            MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetForm();
            return;
        }

        private void resetForm()
        {
            txbEmail.Text = "";
            txbSenha.Text = "";
            senhaAntiga = "";
            cboPermissao.SelectedIndex = -1;
        }


        private void ValidarForm()
        {
            if (txbEmail.Text == "")
            {
                mensagem = "Um Usuário deve ser selecionado.";
                return;
            }

            if (txbSenha.Text == "")
            {
                mensagem = "Uma senha deve ser selecionada.";
                return;
            }

            if (cboPermissao.SelectedIndex == -1)
            {
                mensagem = "Uma permissão deve ser selecionada.";
                return;
            }

            //VALIDAR COMBO.
            validarCombo();
            int auxPermissao = Convert.ToInt32(cboPermissao.SelectedIndex);
            mensagem = loginDao.cadastrar(txbEmail.Text, txbSenha.Text, null, auxPermissao);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txbEmail.TextLength < 0 || txbSenha.TextLength < 0 || cboPermissao.SelectedIndex < 0)
            {
                mensagem = "Erro ao alterar, verifique todos os dados.";
            }
            else
            {
                validarCombo();
                mensagem = loginDao.alterar(txbEmail.Text, txbSenha.Text, aux, senhaAntiga);
                MessageBox.Show(mensagem, "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Preencher a tabela com as novas informações após realizar alteração.
                btnConsultarTodos();
                resetForm();
                return;
            }
            if (mensagem != "")
            {
                MessageBox.Show(mensagem, "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            mensagem = loginDao.excluir(txbEmail.Text, txbSenha.Text);
            MessageBox.Show(mensagem, "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpaDatagrid();
            resetForm();
            return;
        }

        private void validarCombo()
        {
            //É o reponsável por decidir qual PERMISSAO o usuário tem.
            permissao = cboPermissao.Text.Substring(0, 1);
            if (permissao == "1") //Permissão Gerente
            {
                aux = 1;
            }
            if (permissao == "2") //Permissão Funcionário
            {
                aux = 2;
            }
        }
    }
}
