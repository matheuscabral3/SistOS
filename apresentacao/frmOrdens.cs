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


        public frmOrdens()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "INSERT INTO tbOrdens(nome_cliente, equipamento, nome_tecnico, data_entrada, obs, orcamento) VALUES(@nome_cliente,@equipamento,@nome_tecnico,@data_entrada,@obs,@orcamento)";
            cmd.Parameters.AddWithValue("@nome_cliente", txbNomeCliente.Text);
            cmd.Parameters.AddWithValue("@equipamento", txbEquip.Text);
            cmd.Parameters.AddWithValue("@nome_tecnico", txbNomeTec.Text);
            cmd.Parameters.AddWithValue("@data_entrada", txbDataEntrada.Text);
            cmd.Parameters.AddWithValue("@obs", txbObs.Text);
            cmd.Parameters.AddWithValue("@orcamento", txbOrcamento.Text);

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();
                MessageBox.Show("Ordem Emitida com Sucesso !!!");
            }
            catch
            {
                MessageBox.Show("Erro ao Emitir Ordem");
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
    }
}
