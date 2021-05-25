using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp1.apresentacao
{
    public partial class frmCadEquipamento : Form
    {
        SqlDataReader dr = null;
        Thread th;
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter();
        frmMenu frmMenu = new frmMenu();
        conexao con = new conexao();
        SqlCommand cmd = new SqlCommand();
        string mensagem = "";
        public frmCadEquipamento()
        {
            InitializeComponent();
        }

        private void btnCadEquip_Click(object sender, EventArgs e)
        {


            float auxiliar = float.Parse(txbPreco.Text);
            cmd.CommandText = "INSERT INTO tbEquipamentos(nome_equip, tipo_aparelho, valor_peca, estoque_disp)" +
            "VALUES(@nome_equip, @tipo_aparelho,  " + auxiliar + ",  " + Convert.ToInt32(txbEstoqueDisp.Text) + ");";

            cmd.Parameters.AddWithValue("@nome_equip", this.txbNomeEquip.Text);
            cmd.Parameters.AddWithValue("@tipo_aparelho", this.txbModelo.Text);

            //Executar
            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();
                this.mensagem = "Equipamento Cadastrado com Sucesso !";
                MessageBox.Show(mensagem, "Cadastro Realizado !", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (SqlException)
            {
                this.mensagem = "Erro ao Cadastrar Equipamento !";
                MessageBox.Show(mensagem, "Erro Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //Executar código


        }

        private void consultarTodos()
        {

            try
            {
                string strSQL = "SELECT * FROM tbEquipamentos;";
                cmd = new SqlCommand(strSQL, con.conectar());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dtEquipamentos.DataSource = dt;
                con.desconectar();
            }
            catch
            {
                this.mensagem = "Erro ao Consultar Equipamento!";
                MessageBox.Show(mensagem, "Erro Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }



        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            //th = new Thread(opennewform);
            //th.SetApartmentState(ApartmentState.STA);
            //th.Start();
        }

        private void opennewform(object obj)
        {

            // Application.Run(new xxxNomedoFormxxx());

        }

        private void fmrCadEquipamento_Load(object sender, EventArgs e)
        {
            resetarForm();
        }

        private void ValidarControles()
        {
            if (txbNomeEquip.Text == "" || txbModelo.Text == "" || txbPreco.Text == "")
            {
                MessageBox.Show("Preencha todos os campos !", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void resetarForm()
        {
            txbNomeEquip.Text = "";
            txbModelo.Text = "";
            txbEstoqueDisp.Text = "";
            txbPreco.Text = "";
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            consultarTodos();
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //UPDATE tbEquipamentos SET nome_equip = 'novoHeadSet' WHERE nome_equip = 'Headset';

        }
    }
}
