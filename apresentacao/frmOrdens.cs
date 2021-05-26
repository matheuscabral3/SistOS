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


        public frmOrdens()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            //Validar
            ValidarControles();
            if (this.mensagem.Length > 0)
            {
                MessageBox.Show(mensagem, "Erro ao Gerar OS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            float auxiliarOrcamento = float.Parse(txbOrcamento.Text);
            cmd.CommandText = "INSERT INTO tbOrdens(nome_cliente, nome_equip, nome_tecnico, data_entrada, obs, orcamento, situacao) " +
            "VALUES(@nome_cliente, @equipamento, @nome_tecnico, @data_entrada, @obs, @orcamento, " + auxiliarOrcamento + ");";

            cmd.Parameters.AddWithValue("@nome_cliente", txbNomeCliente.Text);
            cmd.Parameters.AddWithValue("@equipamento", txbEquip.Text);
            cmd.Parameters.AddWithValue("@nome_tecnico", txbNomeTec.Text);
            cmd.Parameters.AddWithValue("@data_entrada", txbDataEntrada.Text);
            cmd.Parameters.AddWithValue("@obs", txbObs.Text);
            cmd.Parameters.AddWithValue("@orcamento", txbOrcamento.Text);
            cmd.Parameters.AddWithValue("@situacao", txbSituacao.Text);

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
            catch
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
