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
        int auxEstoque;
        bool tem = false;


        public frmCadEquipamento()
        {
            InitializeComponent();
        }

        private void btnCadEquip_Click(object sender, EventArgs e)
        {
            //VALIDAR CONTROLES
            ValidarControles();
            if (this.mensagem.Length > 0)
            {
                MessageBox.Show(mensagem, "Erro ao Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //VALIDAR EQUIPAMENTO EXISTENTE
            bool validar = verificarEquipamento(txbNomeEquip.Text);
            if (validar == true)
            {
                MessageBox.Show(mensagem, "Erro ao Cadastrar.", MessageBoxButtons.OK);
                return;
            }


            double auxiliar = double.Parse(txbValor.Text);
            cmd.CommandText = "INSERT INTO tbEquipamentos(nome_equip, tipo_aparelho, valor_peca, estoque_disp)" +
            "VALUES(@nome_equip, @tipo_aparelho,  " + auxiliar + ",  " + auxEstoque + ");";

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
                resetForm();
                limpaDataGrid();
                return;

            }
            catch (SqlException)
            {
                this.mensagem = "Erro ao Cadastrar Equipamento !";
                MessageBox.Show(mensagem, "Erro Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


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


        //---------------------------------
        //MÉTODO PARA VERIFICAR EQUIPAMENTO EXISTENTE
        //---------------------------------
        public bool verificarEquipamento(string nomeEquip)//Verificar no Banco de Dados, se possui valor com esse parâmetro
        {
            try
            {

                if (nomeEquip != "")
                {
                    //VERIFICAÇÃO DE INCLUSÃO - SELECT > INSERT
                    cmd.CommandText = "SELECT * FROM tbEquipamentos WHERE nome_equip ='" + nomeEquip + "'; ";
                }

                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();  //Pegar a informação e guardar em algum lugar ? ==> dr;
                if (dr.HasRows)  //se foi encontrado
                {
                    this.mensagem = "Equipamento já existe.";
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

        }

        private void ValidarControles()
        {
            auxEstoque = Convert.ToInt32(txbEstoqueDisp.Text);
            if (txbNomeEquip.Text == "" || txbModelo.Text == "" || txbValor.Text == "" || txbEstoqueDisp.Text == "")
            {
                this.mensagem = "Preencha todos os campos.";
                return;
            }
        }


        //---------------------------------
        //MÉTODO PARA RESETAR FORMULARIO
        //---------------------------------
        private void resetForm()
        {
            txbNomeEquip.Text = "";
            txbModelo.Text = "";
            txbEstoqueDisp.Text = "";
            txbValor.Text = "";
        }


        //---------------------------------
        //MÉTODO PARA CONSULTAR TODOS
        //---------------------------------
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            consultarTodos();
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //UPDATE tbEquipamentos SET nome_equip = 'novoHeadSet' WHERE nome_equip = 'Headset';

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
            if (dtEquipamentos.DataSource != null)
            {
                int numRows = dtEquipamentos.Rows.Count;
                for (int i = 0; i < numRows; i++)
                {
                    try
                    {
                        int max = dtEquipamentos.Rows.Count - 1;
                        dtEquipamentos.Rows.Remove(dtEquipamentos.Rows[max]);

                    }
                    catch (Exception exe)
                    {
                        MessageBox.Show("Erro ao Limpar Tabela" + exe, "WTF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
            dtEquipamentos.DataSource = null;
            dtEquipamentos.Refresh();
            return;
        }






    }
}
