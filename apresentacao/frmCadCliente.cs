using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1.apresentacao
{
    public partial class frmCadCliente : Form
    {
        Thread th;
        conexao con = new conexao();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr = null;
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter();
        string mensagem = "";


        public frmCadCliente()
        {
            InitializeComponent();
        }

        //CONSULTAR
        private void btnConsultar_Click(object sender, EventArgs e)
        {

            limpaDataGrid();

            //if (txbNome.TextLength > 0)
            //{
            //    try
            //    {
            //        string strSQL = "SELECT * FROM tbClientes";
            //        cmd = new SqlCommand(strSQL, con.conectar());
            //        SqlDataAdapter da = new SqlDataAdapter(cmd);
            //        da.Fill(dt);
            //        dtClientes.DataSource = dt;
            //        con.desconectar();
            //    }
            //    catch
            //    {
            //        this.mensagem = "Erro ao Consultar Cliente !";
            //        MessageBox.Show(mensagem, "Erro Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    return;
            //}

            consultarTodos();
            return;

        }

        private void consultarTodos()
        {

            try
            {
                string strSQL = "SELECT * FROM tbClientes";
                cmd = new SqlCommand(strSQL, con.conectar());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dtClientes.DataSource = dt;
                con.desconectar();
            }
            catch
            {
                this.mensagem = "Erro ao Consultar Cliente !";
                MessageBox.Show(mensagem, "Erro Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnVoltar_Click(object sender, EventArgs e)
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {


            //cmd.CommandText = "INSERT INTO tbClientes(nome, cidade, email, telefone, endereco) VALUES(@nome, @cidade, @email, @telefone, @endereco)";

            cmd.CommandText = "INSERT INTO tbClientes(nome, cidade, email, telefone, endereco, numero, bairro, CPF, RG)" +
            "VALUES(@nome, @cidade, @email, @telefone, @endereco, @numero, @bairro, @CPF, @RG);";

            cmd.Parameters.AddWithValue("@nome", this.txbNome.Text);
            cmd.Parameters.AddWithValue("@cidade", this.txbCidade.Text);
            cmd.Parameters.AddWithValue("@email", this.txbEmail.Text);
            cmd.Parameters.AddWithValue("@telefone", this.txbTel.Text);
            cmd.Parameters.AddWithValue("@endereco", this.txbEnd.Text);
            cmd.Parameters.AddWithValue("@numero", this.txbNumero.Text);
            cmd.Parameters.AddWithValue("@bairro", this.txbBairro.Text);
            cmd.Parameters.AddWithValue("@CPF", this.txbCPF.Text);
            cmd.Parameters.AddWithValue("@RG", this.txbRG.Text);

            //Executar
            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();
                this.mensagem = "Cliente Cadastrado com Sucesso !";
                MessageBox.Show(mensagem, "Cadastro Realizado !", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (SqlException)
            {
                this.mensagem = "Erro ao Cadastrar Cliente !";
                MessageBox.Show(mensagem, "Erro Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void fmrCadCliente_Load(object sender, EventArgs e)
        {

        }

        private void ValidarControles()
        {
            if (txbNome.Text == "" || txbCidade.Text == "" || txbEmail.Text == "" || txbEnd.Text == "" || txbTel.Text == "")
            {
                MessageBox.Show("Preencha todos os campos !", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpaDataGrid();
            resetForm();
            return;
        }


        private void limpaDataGrid()
        {
            if (dtClientes.DataSource != null)
            {
                int numRows = dtClientes.Rows.Count;
                for (int i = 0; i < numRows; i++)
                {
                    try
                    {
                        int max = dtClientes.Rows.Count - 1;
                        dtClientes.Rows.Remove(dtClientes.Rows[max]);

                    }
                    catch (Exception exe)
                    {
                        MessageBox.Show("Erro ao Limpar Tabela" + exe, "WTF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
            dtClientes.DataSource = null;
            dtClientes.Refresh();
            return;
        }


        private void resetForm()
        {
            txbBairro.Text = "";
            txbCidade.Text = "";
            txbCPF.Text = "";
            txbEmail.Text = "";
            txbEnd.Text = "";
            txbNome.Text = "";
            txbNumero.Text = "";
            txbRG.Text = "";
            txbTel.Text = "";
        }

    }
}
