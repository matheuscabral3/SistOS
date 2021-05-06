using System;
using System.Windows.Forms;
using WindowsFormsApp1.apresentacao;
using WindowsFormsApp1.modelo;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class cadastreSe : Form
    {
        Thread th;
        controle controle = new controle();
        frmMenu frmMenu = new frmMenu();
        string mensagem = "";

        public cadastreSe()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            //  ValidarControles();

            string permissao = cboPermissao.Text.Substring(0, 1);

            //Instânciar o cadastro
            mensagem = controle.cadastrar(txbLogin.Text, txbSenha.Text, txbConfSenha.Text, permissao); //Passar as TextBox's > CONTROLE
            if (controle.tem)//Mensagem de Sucesso
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else //Mensagem de Erro
            {
                MessageBox.Show(controle.mensagem);
            }
            //antes de cadastrar, vê se já existe email com esse nome
        }

        public void ValidarControles()
        {
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void opennewform(object obj)
        {

            Application.Run(new frmTelaLogin());

        }

        private void cboPermissao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cadastreSe_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
