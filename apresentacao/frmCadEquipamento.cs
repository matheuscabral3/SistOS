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
        double auxValor;
        bool tem = false;
        string mstrNome = "";
        string mstrTipo = "";


        public frmCadEquipamento()
        {
            InitializeComponent();
        }

        private void btnCadEquip_Click(object sender, EventArgs e)
        {
            this.mensagem = "";

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
                MessageBox.Show(mensagem, "Erro ao Cadastrar, item já existente.", MessageBoxButtons.OK);
                return;
            }


            cmd.CommandText = "INSERT INTO tbEquipamentos(nome_equip, tipo_aparelho, valor_peca, estoque_disp)" +
            "VALUES(@nome_equip, @tipo_aparelho,  " + txbValor.Text + ",  " + auxEstoque + ");";

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
                configuraDatagrid();
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

            if (txbNomeEquip.Text == "" || txbModelo.Text == "")
            {
                this.mensagem = "Preencha todos os campos.";
                return;
            }


            auxValor = Convert.ToDouble(txbValor.Text);
            auxEstoque = Convert.ToInt32(txbEstoqueDisp.Text);


            if (auxValor < 0 || auxEstoque < 0)
            {
                this.mensagem = "Verifique os valores.";
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

        private void dtEquipamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //LÓGICA (Obter o DataGrid > Selecionar a Coluna > Preencher a TextBox)
            //Obter o conteúdo da Linha selecionado.
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtEquipamentos.Rows[e.RowIndex];
                txbNomeEquip.Text = row.Cells["nome_equip"].Value.ToString();
                txbModelo.Text = row.Cells["tipo_aparelho"].Value.ToString();
                txbValor.Text = row.Cells["valor_peca"].Value.ToString();
                txbEstoqueDisp.Text = row.Cells["estoque_disp"].Value.ToString();

            }
            mstrNome = txbNomeEquip.Text;
            mstrTipo = txbModelo.Text;
        }

        private void configuraDatagrid()
        {
            dtEquipamentos.Columns[0].Visible = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // FAZER ALTERAÇÕES NO CÓDIGO ABAIXO PARA A TELA DE CAD EQUIPAMENTO.
            //if (txbNome.TextLength < 0 || txbRG.TextLength < 0)
            //{
            //  this.mensagem = "Erro ao Excluir Cliente no banco, verifique as informações.";
            //MessageBox.Show(mensagem, "Erro Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // return;
            //  }

            // cmd.CommandText = "DELETE FROM tbClientes WHERE nome = @nome AND RG = @RG;";
            //cmd.Parameters.AddWithValue("@nome", this.txbNome.Text);
            //cmd.Parameters.AddWithValue("@RG", this.txbRG.Text);

            //try
            // {
            // cmd.Connection = con.conectar(); //Abrir conexão
            // cmd.ExecuteNonQuery(); //Executar Comando
            // con.desconectar(); //Fechar Conexão
            //  this.mensagem = "Cliente Excluido com Sucesso !!";
            //MessageBox.Show(mensagem, "Exclusão Concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // resetForm();
            // limpaDataGrid();
            // return;
            //  }
            // catch (Exception)//Mensagem Erro de Cadastro
            //  {
            //  this.mensagem = "Erro ao Excluir Cliente, verifique as informações.";
            // MessageBox.Show(mensagem, "Erro Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // return;
            // }
        }
    }
}
