using System;
using System.Threading;
using System.Windows.Forms;
using WindowsFormsApp1.modelo;

namespace WindowsFormsApp1.apresentacao
{
    public partial class frmTelaLogin : Form
    {
        Thread th;
        controle controle = new controle();
        frmMenu frmMenu = new frmMenu();
        string mensagem = "";


        public frmTelaLogin()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            //==== MODELO ANTIGO PARA ABRIR O FORMULARIO ======
            //frmCadUsuario frmCadUsuario = new frmCadUsuario();
            //frmCadUsuario.Show();//Mostrar o formulário de Cadastro, quando clicar no botão


            //==== NOVO MODELO PARA ABRIR O FORMULARIO ======
            this.Close();
            th = new Thread(openformMenu);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openformMenu()
        {
            Application.Run(new frmCadUsuario());
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {

            ValidarControles();
            if (this.mensagem == "")
            {
                controle.acessar(txbLogin.Text, txbSenha.Text); //Enviar informação do Formulário de Login
                if (controle.mensagem.Equals(""))
                {
                    if (controle.tem) //Se todos os comandos forem Executados
                    {
                        this.mensagem = "Logado com sucesso.";
                        MessageBox.Show(mensagem, "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        th = new Thread(openformMenu);
                        th.SetApartmentState(ApartmentState.STA);
                        th.Start();
                    }
                    else//Se não forem, apenas a mensagem de erro.
                    {
                        this.mensagem = "Login não encontrado, verifique novamente.";
                        MessageBox.Show(mensagem, "Erro ao Acessar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show(controle.mensagem);
                }

            }
            else
            {
                return;
            }

        }



        private void ValidarControles()
        {
            if (txbLogin.Text == "" || txbSenha.Text == "")
            {
                this.mensagem = "Preencha todos os campos.";
                MessageBox.Show(mensagem, "Erro ao Acessar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void frmTelaLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
