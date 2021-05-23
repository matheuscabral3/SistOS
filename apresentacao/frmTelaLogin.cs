using System;
using System.Windows.Forms;
using WindowsFormsApp1.modelo;
using System.Threading;

namespace WindowsFormsApp1.apresentacao
{
    public partial class frmTelaLogin : Form
    {
        Thread th;
        controle controle = new controle();
        frmMenu frmMenu = new frmMenu();


        public frmTelaLogin()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadUsuario frmCadUsuario = new frmCadUsuario();
            frmCadUsuario.Show();//Mostrar o formulário de Cadastro, quando clicar no botão
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {

            ValidarControles();

            controle.acessar(txbLogin.Text, txbSenha.Text); //Enviar informação do Formulário de Login
            if (controle.mensagem.Equals(""))
            {
                if (controle.tem) //Se todos os comandos forem Executados
                {
                    MessageBox.Show("Logado com Sucesso !!", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    th = new Thread(openformMenu);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                else//Se não forem, apenas a mensagem de erro.
                {
                    MessageBox.Show("Login não encontrado, verifique login e senha !!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }

        }

        private void openformMenu()
        {
            Application.Run(new frmMenu());
        }

        private void ValidarControles()
        {
            if (txbLogin.Text == "" || txbSenha.Text == "")
            {
                MessageBox.Show("Preencha todos os campos !", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmTelaLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
