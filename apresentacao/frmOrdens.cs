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

namespace WindowsFormsApp1.apresentacao
{
    public partial class frmOrdens : Form
    {
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
            frmMenu.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
