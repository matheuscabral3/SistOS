using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp1.apresentacao
{
    public partial class frmOrdens : Form
    {
        Thread th;
        conexao con = new conexao();
        SqlCommand cmd = new SqlCommand();
        frmMenu frmMenu = new frmMenu();
        string mensagem = "";
        decimal auxiliarOrcamento;

        public frmOrdens()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            this.mensagem = "";
            //Validar
            ValidarControles();
            if (this.mensagem.Length > 0)
            {
                MessageBox.Show(mensagem, "Erro ao Gerar OS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            cmd.CommandText = "INSERT INTO tbOrdens(nome_cliente, nome_equip, nome_tecnico, data_entrada, obs, orcamento, situacao) " +
            "VALUES(@nome_cliente, @nome_equip, @nome_tecnico, @data_entrada, @obs, " + auxiliarOrcamento + " , @situacao);";

            string updateSQL = cmd.CommandText;

            if (auxiliarOrcamento > 100 && auxiliarOrcamento < 1000) //Verificar a conversão do valor
            {
                updateSQL = updateSQL.Remove(175, 1).Insert(175, ".");
            }
            if (auxiliarOrcamento < 100)
            {
                updateSQL = updateSQL.Remove(174, 1).Insert(174, ".");
            }
            if (auxiliarOrcamento > 1000)
            {
                updateSQL = updateSQL.Remove(176, 1).Insert(176, ".");
            }

            cmd.CommandText = updateSQL;


            cmd.Parameters.AddWithValue("@nome_cliente", txbNomeCliente.Text);
            cmd.Parameters.AddWithValue("@nome_equip", txbEquip.Text);
            cmd.Parameters.AddWithValue("@nome_tecnico", txbNomeTec.Text);
            cmd.Parameters.AddWithValue("@data_entrada", txbDataEntrada.Text);
            cmd.Parameters.AddWithValue("@obs", txbObs.Text);
            cmd.Parameters.AddWithValue("@situacao", txbSituacao.Text);
            // cmd.Parameters.AddWithValue("@orcamento", txbOrcamento.Text);

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();
                this.mensagem = "Ordem Emitida com Sucesso !!!";
                MessageBox.Show(mensagem, "Concluído.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetForm();
                return;

            }
            catch (SqlException)
            {
                this.mensagem = "Erro com o banco ao Emitir OS.";
                MessageBox.Show(mensagem, "Erro Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


        }

        private void resetForm()
        {
            txbSituacao.Text = "";
            txbOrcamento.Text = "";
            txbObs.Text = "";
            txbNomeTec.Text = "";
            txbNomeCliente.Text = "";
            txbEquip.Text = "";
            txbDataEntrada.Text = "";
            return;
        }

        private void ValidarControles()
        {

            if (txbNomeTec.Text == "" || txbNomeCliente.Text == "" || txbEquip.Text == "" || txbDataEntrada.Text == "" || txbObs.Text == "" || txbOrcamento.Text == "" || txbSituacao.Text == "")
            {
                this.mensagem = "Erro ao Gerar OS, verifique todos os campos.";
                return;
            }

            auxiliarOrcamento = decimal.Parse(txbOrcamento.Text);

            if (auxiliarOrcamento < 0)
            {
                this.mensagem = "O Orçamento não pode ter um valor negativo.";
                return;
            }

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            //  th = new Thread(openformMenu);
            //  th.SetApartmentState(ApartmentState.STA);
            //  th.Start();
        }


        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void openformMenu()
        {
            Application.Run(new frmMenu());
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

            printDocument1.Print();
            return;
        }
    }
}
