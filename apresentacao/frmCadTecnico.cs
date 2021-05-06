using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp1.apresentacao
{
    public partial class frmCadTecnico : Form
    {
        Thread th;
        conexao con = new conexao();
        SqlCommand cmd = new SqlCommand();
        frmMenu frmMenu = new frmMenu();


        public frmCadTecnico()
        {
            InitializeComponent();
        }

        private void btnCadastrarTec_Click(object sender, EventArgs e)
        {

            ValidarControles();

            try
            {
                cmd.CommandText = "INSERT into tbTecnico(nome, telefone, email, cidade, endereco) " +
                "VALUES(" + txbNome.Text + ", " + txbTel.Text + ", " + txbEmail.Text + ", " + txbCidade.Text + ", " + txbEnd.Text + ");";

                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();
                MessageBox.Show("Técnico Cadastrado com Sucesso !!");
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao cadastrar técnico");
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openformMenu);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void fmrCadTecnico_Load(object sender, EventArgs e)
        {

        }

        private void ValidarControles()
        {
            if (txbNome.Text == "" || txbEmail.Text == "" || txbCidade.Text == "" || txbEnd.Text == "" || txbTel.Text == "")
            {
                MessageBox.Show("Preencha todos os campos !", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void openformMenu()
        {
            Application.Run(new frmMenu());
        }
    }
}
