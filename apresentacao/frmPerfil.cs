using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;
using WindowsFormsApp1.dal;
using WindowsFormsApp1.modelo;

namespace WindowsFormsApp1.apresentacao
{
    public partial class frmPerfil : Form
    {
        Thread th;
        LoginDaoComandos loginDao = new LoginDaoComandos();
        controle controle = new controle();
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

            limpaDatagrid();

            try
            {
                if (txbEmail.TextLength > 0)
                {
                    string strSQL = "SELECT * FROM tbUsuarios " +
                        "WHERE usuarios LIKE '%" + txbEmail.Text + "%';";
                    cmd = new SqlCommand(strSQL, con.conectar());
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dtPerfil.DataSource = dt;
                    con.desconectar();
                    return;
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


        //---------------------------------
        //MÉTODO PARA CONSULTAR
        //---------------------------------
        private void btnConsultarTodos()
        {

            limpaDatagrid();

            try
            {
                string strSQL = "SELECT * FROM tbUsuarios";
                cmd = new SqlCommand(strSQL, con.conectar());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dtPerfil.DataSource = dt;
                con.desconectar();
            }
            catch
            {
                MessageBox.Show("Erro ao Preencher a Tabela !");
            }


        }


        //---------------------------------
        //MÉTODO CLICK
        //---------------------------------
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

        //---------------------------------
        //MÉTODO LOAD
        //---------------------------------
        private void fmrEditarPerfil_Load(object sender, EventArgs e)
        {
            resetForm();
        }


        //---------------------------------
        //MÉTODO RETORNAR
        //---------------------------------
        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openformMenu);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        //---------------------------------
        //MÉTODO PARA ABRIR O NOVO FORM
        //---------------------------------
        private void openformMenu()
        {
            Application.Run(new frmMenu());
        }


        //---------------------------------
        //MÉTODO PARA ATUALIZAR CAIXA DE TEXTO
        //---------------------------------
        private void txbEmail_TextChanged_1(object sender, EventArgs e)
        {
            txbSenha.Text = "";
            //cboPermissao.SelectedIndex = cboPermissao.SelectedIndex;
        }


        //---------------------------------
        //MÉTODO PARA INCLUIR
        //---------------------------------
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            //VERIFICAR SE U USUÁRIO JÁ EXISTE, ANTES DE REALIZAR A INCLUSÃO
            bool usuarioExiste = loginDao.verificarLogin(txbEmail.Text, "");//Método verificarLogin da classe LoginDaoComandos
            if (usuarioExiste == true)
            {
                this.mensagem = "Este usuário já existe !";
                MessageBox.Show(mensagem, "Já Existente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetForm();
                return;
            }

            ValidarForm();
            MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            resetForm();
            return;
        }


        //---------------------------------
        //MÉTODO PARA RESETAR
        //---------------------------------
        private void resetForm()
        {
            txbEmail.Text = "";
            txbSenha.Text = "";
            senhaAntiga = "";
            cboPermissao.SelectedIndex = -1;
        }



        //---------------------------------
        //MÉTODO PARA VALIDAR
        //---------------------------------
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
            int auxPermissao = aux;
            string auxSenha = txbSenha.Text;
            mensagem = loginDao.cadastrar(txbEmail.Text, txbSenha.Text, auxSenha, auxPermissao);
        }


        //---------------------------------
        //MÉTODO PARA ALTERAR
        //---------------------------------
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


        //---------------------------------
        //MÉTODO PARA EXCLUIR
        //---------------------------------
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            mensagem = loginDao.excluir(txbEmail.Text, txbSenha.Text);
            MessageBox.Show(mensagem, "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpaDatagrid();
            resetForm();
            return;
        }


        //---------------------------------
        //MÉTODO PARA VALIDAR COMBO
        //---------------------------------
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



        //---------------------------------
        //MÉTODO PARA LIMPAR O DATAGRIDVIEW
        //---------------------------------
        private void limpaDatagrid()
        {
            if (dtPerfil.DataSource != null)
            {
                int numRows = dtPerfil.Rows.Count;
                for (int i = 0; i < numRows; i++)
                {
                    try
                    {
                        int max = dtPerfil.Rows.Count - 1;
                        dtPerfil.Rows.Remove(dtPerfil.Rows[max]);

                    }
                    catch (Exception exe)
                    {
                        MessageBox.Show("Erro ao Limpar Tabela" + exe, "WTF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
            dtPerfil.DataSource = null;
            dtPerfil.Refresh();
            return;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpaDatagrid();
            resetForm();
        }

    }
}
