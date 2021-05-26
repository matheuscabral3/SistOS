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
        string mstrNome = "";
        string mstrRG = "";
        bool tem = false;


        public frmCadCliente()
        {
            InitializeComponent();
        }

        //---------------------------------
        //MÉTODO PARA CONSULTAR
        //---------------------------------
        private void btnConsultar_Click(object sender, EventArgs e)
        {

            limpaDataGrid();
            if (txbEmail.Text == "")
            {
                consultarTodos();
                return;
            }

            try
            {
                if (txbEmail.TextLength > 0)
                {
                    string strSQL = "SELECT * FROM tbUsuarios " +
                        "WHERE usuarios LIKE '%" + txbEmail.Text + "%';";
                    cmd = new SqlCommand(strSQL, con.conectar());
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dtClientes.DataSource = dt;
                    con.desconectar();
                    return;
                }


            }
            catch
            {
                this.mensagem = "Erro ao Consultar Cliente no banco, verifique as informações.";
                MessageBox.Show(mensagem, "Erro Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }

        //---------------------------------
        //MÉTODO PARA CADASTRAR
        //---------------------------------
        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            this.mensagem = "";

            //Validar
            ValidarControles();
            if (this.mensagem.Length > 0)
            {
                MessageBox.Show(mensagem, "Erro ao Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //VALIDAR SE O CLIENTE JÁ EXISTE
            bool validar = verificarCliente(txbNome.Text);
            if (validar == true)
            {
                MessageBox.Show(mensagem, "Erro ao Cadastrar.", MessageBoxButtons.OK);
                return;
            }

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
                this.mensagem = "Cliente Cadastrado com Sucesso.";
                MessageBox.Show(mensagem, "Cadastro Realizado.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetForm();
                return;

            }
            catch (SqlException)
            {
                this.mensagem = "Erro ao Cadastrar Cliente no banco, verifique as informações.";
                MessageBox.Show(mensagem, "Erro Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        //---------------------------------
        //MÉTODO PARA CADASTRAR
        //---------------------------------
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //VALIDAR LÓGICA DE ALTERAÇÃO
            cmd.CommandText = "UPDATE tbClientes SET nome = @nome, cidade = @cidade, email = @email, telefone = @telefone, endereco = @endereco, " +
            " numero = @numero, bairro = @bairro, CPF = @CPF, RG = @RG " +
            " WHERE nome = '" + mstrNome + "' AND RG = '" + mstrRG + "';";

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
                this.mensagem = "Cliente Alterado com Sucesso.";
                MessageBox.Show(mensagem, "Alteração Concluída.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpaDataGrid();
                resetForm();
                return;

            }
            catch (SqlException)
            {
                this.mensagem = "Erro ao Alterar Cliente no banco, verifique as informações.";
                MessageBox.Show(mensagem, "Erro Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        //---------------------------------
        //MÉTODO PARA CADASTRAR
        //---------------------------------
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txbNome.TextLength < 0 || txbRG.TextLength < 0)
            {
                this.mensagem = "Erro ao Excluir Cliente no banco, verifique as informações.";
                MessageBox.Show(mensagem, "Erro Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            cmd.CommandText = "DELETE FROM tbClientes WHERE nome = @nome AND RG = @RG;";
            cmd.Parameters.AddWithValue("@nome", this.txbNome.Text);
            cmd.Parameters.AddWithValue("@RG", this.txbRG.Text);

            try
            {
                cmd.Connection = con.conectar(); //Abrir conexão
                cmd.ExecuteNonQuery(); //Executar Comando
                con.desconectar(); //Fechar Conexão
                this.mensagem = "Cliente Excluido com Sucesso !!";
                MessageBox.Show(mensagem, "Exclusão Concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetForm();
                limpaDataGrid();
                return;
            }
            catch (Exception)//Mensagem Erro de Cadastro
            {
                this.mensagem = "Erro ao Excluir Cliente, verifique as informações.";
                MessageBox.Show(mensagem, "Erro Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }

        //---------------------------------
        //MÉTODO PARA CONSULTAR TODOS
        //---------------------------------
        private void consultarTodos()
        {

            try
            {
                string strSQL = "SELECT * FROM tbClientes;";
                cmd = new SqlCommand(strSQL, con.conectar());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dtClientes.DataSource = dt;
                con.desconectar();
                return;
            }
            catch
            {
                this.mensagem = "Erro ao Consultar Cliente !";
                return;
            }
        }

        //---------------------------------
        //MÉTODO PARA VOLTAR AO MENU
        //---------------------------------
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            // th = new Thread(openformMenu);
            // th.SetApartmentState(ApartmentState.STA);
            // th.Start();
        }

        //---------------------------------
        //MÉTODO PARA ABRIR FORMULARIO
        //---------------------------------
        private void openformMenu()
        {
            Application.Run(new frmMenu());
        }

        //---------------------------------
        //MÉTODO LOAD
        //---------------------------------
        private void fmrCadCliente_Load(object sender, EventArgs e)
        {

        }

        //---------------------------------
        //MÉTODO PARA VALIDAR CONTROLES
        //---------------------------------
        private void ValidarControles()
        {
            if (txbNome.Text == "" || txbCidade.Text == "" || txbEmail.Text == "" || txbEnd.Text == "" || txbTel.Text == "")
            {
                this.mensagem = "Preencha todos os campos.";
                // MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        //---------------------------------
        //MÉTODO PARA LIMPAR A TABELA
        //---------------------------------
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpaDataGrid();
            resetForm();
            return;
        }

        //---------------------------------
        //MÉTODO PARA LIMPAR A TABELA
        //---------------------------------
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

        //---------------------------------
        //MÉTODO PARA RESETAR FORMULARIO
        //---------------------------------
        private void resetForm()
        {
            txbNome.Text = "";
            txbEmail.Text = "";
            txbCidade.Text = "";
            txbBairro.Text = "";
            txbEnd.Text = "";
            txbNumero.Text = "";
            txbTel.Text = "";
            txbRG.Text = "";
            txbCPF.Text = "";
            return;
        }


        //---------------------------------
        //MÉTODO PARA VERIFICAR CLIENTE EXISTENTE
        //---------------------------------
        public bool verificarCliente(string nome)//Verificar no Banco de Dados, se possui valor com esse parâmetro
        {
            try
            {

                if (nome != "")
                {
                    //VERIFICAÇÃO DE INCLUSÃO - SELECT > INSERT
                    cmd.CommandText = "SELECT * FROM tbClientes WHERE nome ='" + nome + "'; ";
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


        //---------------------------------
        //MÉTODO PARA CLICK
        //---------------------------------
        private void dtClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //LÓGICA (Obter o DataGrid > Selecionar a Coluna > Preencher a TextBox)
            //Obter o conteúdo da Linha selecionado.
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtClientes.Rows[e.RowIndex];
                txbNome.Text = row.Cells["nome"].Value.ToString();
                txbCidade.Text = row.Cells["cidade"].Value.ToString();
                txbEmail.Text = row.Cells["email"].Value.ToString();
                txbTel.Text = row.Cells["telefone"].Value.ToString();
                txbEnd.Text = row.Cells["endereco"].Value.ToString();
                txbNumero.Text = row.Cells["numero"].Value.ToString();
                txbBairro.Text = row.Cells["bairro"].Value.ToString();
                txbCPF.Text = row.Cells["CPF"].Value.ToString();
                txbRG.Text = row.Cells["RG"].Value.ToString();
            }
            mstrNome = txbNome.Text;
            mstrRG = txbRG.Text;
        }


    }
}
