using System;
using System.Windows.Forms;
using WindowsFormsApp1.apresentacao;
using WindowsFormsApp1.modelo;
using WindowsFormsApp1.dal;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class frmCadUsuario : Form
    {
        Thread th;
        controle controle = new controle();
        LoginDaoComandos loginDao = new LoginDaoComandos();
        string mensagem = "";

        public frmCadUsuario()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            this.mensagem = "";

            //VALIDAR CONTROLES
            ValidarControles();
            if (this.mensagem.Length > 0)
            {
                MessageBox.Show(mensagem, "Erro ao Cadastrar.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string permissao = cboPermissao.Text.Substring(0, 1);

            //VERIFICAR SE JÁ POSSUI UM USUÁRIO CADASTRADO
            bool usuarioExiste = loginDao.verificarLogin(txbLogin.Text, "");
            if (usuarioExiste == true)
            {
                this.mensagem = "Este usuário já existe !";
                MessageBox.Show(mensagem, "Já Existente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetForm();
                return;
            }

            //CADASTRAR USUARIO
            mensagem = controle.cadastrar(txbLogin.Text, txbSenha.Text, txbConfSenha.Text, permissao); //Passar as TextBox's > CONTROLE
            if (controle.tem)//Mensagem de Sucesso
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetForm();
                return;
            }
            else //Mensagem de Erro
            {
                MessageBox.Show(controle.mensagem);
            }

        }

        public void ValidarControles()
        {
            if (txbLogin.Text == "" || txbSenha.Text == "" || txbConfSenha.Text == "")
            {

                this.mensagem = "Preencha todos os campos.";
                return;
            }

            if (cboPermissao.SelectedIndex == -1)
            {
                this.mensagem = "Informe um nível de permissão.";
                return;
            }
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


        private void ResetForm()
        {
            txbLogin.Text = "";
            txbSenha.Text = "";
            txbConfSenha.Text = "";
            cboPermissao.SelectedIndex = -1;
        }
    }
}
