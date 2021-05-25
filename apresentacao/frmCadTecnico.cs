using System;
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
        public string mensagem;



        public frmCadTecnico()
        {
            InitializeComponent();
        }

        private void btnCadastrarTec_Click(object sender, EventArgs e)
        {

            ValidarControles();

            try
            {
                cmd.CommandText = "INSERT INTO tbTecnicos(nome_tecnico, telefone, email, cidade, endereco, bairro, cargo, CPF, RG) " +
                "VALUES('" + txbNome.Text + "', '" + txbTEL.Text + "', '" + txbEmail.Text + "', '" + txbCidade.Text + "', '" + txbEnd.Text + "', '" + txbBairro.Text + "', '" + txbCargo.Text + "', '" + txbCPF.Text + "', '" + txbRG.Text + "');";

                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();
                this.mensagem = "Tecnico Registrado com Sucesso !!";
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com o Banco de Dados ao Cadastrar Tecnico !!";
            }

            MessageBox.Show(mensagem, "Incluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
           // th = new Thread(openformMenu);
           // th.SetApartmentState(ApartmentState.STA);
           // th.Start();
        }

        private void fmrCadTecnico_Load(object sender, EventArgs e)
        {
            txbCargo.Text = "Tecnico";
            txbCargo.Enabled = false;
        }

        private void ValidarControles()
        {
            if (txbNome.Text == "" || txbEmail.Text == "" || txbCidade.Text == "" || txbEnd.Text == "" || txbTEL.Text == "" || txbBairro.Text == "" || txbCargo.Text == "" || txbCPF.Text == "" || txbRG.Text == "")
            {
                MessageBox.Show("Preencha todos os campos !", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        } 

        private void openformMenu()
        {
            Application.Run(new frmMenu());
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandText = "DELETE FROM tbTecnicos WHERE nome_tecnico = '" + txbNome.Text + "' AND RG = '" + txbRG.Text + "';";

                cmd.Connection = con.conectar(); //Abrir conexão
                cmd.ExecuteNonQuery(); //Executar Comando
                con.desconectar(); //Fechar Conexão
                this.mensagem = "Tecnico Excluido com Sucesso !!";
                //tem = true;
            }
            catch (Exception)//Mensagem Erro de Cadastro
            {
                this.mensagem = "Erro ao Excluir usuário no Banco de Dados !";
            }
            MessageBox.Show(mensagem, "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;  //Retornar mensagem "Cadastrado com sucesso" ou "Erro de Cadastro"
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbNome.TextLength > 0)
                {
                    string strSQL = "SELECT * FROM tbTecnicos WHERE nome_tecnico ='" + txbNome.Text + "';";
                    cmd.Connection = con.conectar();
                    dr = cmd.ExecuteReader();  //Pegar a informação e guardar em algum lugar ? ==> dr;
                    cmd = new SqlCommand(strSQL, con.conectar());
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dtTecnicos.DataSource = dt;
                    dr.Close();
                }
                else
                {
                    ConsultarTodos();
                    return;
                }
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

    }
}
