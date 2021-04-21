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
    public partial class fmrCadEquipamento : Form
    {
        frmMenu frmMenu = new frmMenu();
        conexao con = new conexao();
        SqlCommand cmd = new SqlCommand();
        public fmrCadEquipamento()
        {
            InitializeComponent();
        }

        private void btnCadEquip_Click(object sender, EventArgs e)
        {

            ValidarControles();

            try
            {
                cmd.CommandText = "INSERT INTO tbEquipamentos(nome_equip,modelo,valor_peca) " +
                "VALUES(" + txbNomeEquip.Text + ", " + txbModelo.Text + ", " + txbPreco.Text + ", " + txbEstoqueDisp.Text + ");";
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();
                MessageBox.Show("Cadastrado com Sucesso !!!");

            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao Cadastrar equipamento !!!");
            }

            //Executar código


        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
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
    }
}
