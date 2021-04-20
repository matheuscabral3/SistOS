using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.dal;
using WindowsFormsApp1.modelo;
using WindowsFormsApp1.apresentacao;

namespace WindowsFormsApp1.apresentacao
{
    public partial class frmPerfil : Form
    {
        LoginDaoComandos loginDao = new LoginDaoComandos();
        frmMenu frmMenu = new frmMenu();
        conexao con = new conexao();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr = null;
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter();
        public string mensagem = "";

        public frmPerfil()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                limpaDatagrid();
                string strSQL = "SELECT * FROM tbUsuarios WHERE usuarios ='" + txbEmail.Text + "';";
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

        //Método listar o data grid view
        private void btnConsultarTodos_Click(object sender, EventArgs e)
        {
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
        }

        private void limpaDatagrid()
        {
            if (dtPerfil.DataSource != null)
            {
                dtPerfil.DataSource = dt;
                dt.Rows.Clear();
            }
        }

        private void configuraDataGrid()
        {

            //OBRIGATÓRIO - CONFIGURA O HEADER
            dtPerfil.Columns[0].HeaderText = "Usuários";
            dtPerfil.Columns[1].HeaderText = "Senha";
            dtPerfil.Columns[2].HeaderText = "Permissão";

            //OPCIONAL - Ajuste das Colunas.
            dtPerfil.Columns[0].Width = 93;
            dtPerfil.Columns[1].Width = 93;
            dtPerfil.Columns[2].Width = 93;

            //OPCIONAL - Exibir Colunas não visíveis.
            // dtPerfil.Columns[0].Visible = false;
            //  dtPerfil.Columns[1].Visible = false;
            //  dtPerfil.Columns[2].Visible = false;
        }

        private void fmrEditarPerfil_Load(object sender, EventArgs e)
        {
            limpaDatagrid();
            resetForm();
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }


        private void txbEmail_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            //É o reponsável por decidir qual PERMISSAO o usuário tem.
            string permissao = cboPermissao.Text.Substring(0, 1);
            if (permissao == "1") //Permissão Gerente
            {
                cboPermissao.SelectedIndex = 0;
            }
            if (permissao == "2") //Permissão Funcionário
            {
                cboPermissao.SelectedIndex = 1;
            }
            int auxPermissao = Convert.ToInt32(permissao);
            mensagem = loginDao.cadastrar(txbEmail.Text, txbSenha.Text, txbConfSenha.Text, auxPermissao);
            MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            resetForm();
        }

        private void resetForm()
        {
            txbEmail.Text = "";
            txbSenha.Text = "";
            txbConfSenha.Text = "";
            cboPermissao.SelectedIndex = -1;

            //REALIZAR LOGICA
            btnAlterar.Visible = false;
            btnExcluir.Visible = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                string strSQL = "DELETE FROM tbUsuarios WHERE usuarios ='" + txbEmail.Text + "';";
                cmd = new SqlCommand(strSQL, con.conectar());
                MessageBox.Show("Registro Excluido com Sucesso !");
                con.desconectar();
                resetForm();
                limpaDatagrid();
            }
            catch
            {
                MessageBox.Show("Erro ao Excluir Registro !");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //MONTAR LOGICA
        }
    }
}
