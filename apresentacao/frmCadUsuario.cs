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
using WindowsFormsApp1.modelo;
using WindowsFormsApp1.dal;
using WindowsFormsApp1.apresentacao;

namespace WindowsFormsApp1
{
    public partial class cadastreSe : Form
    {
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
            frmMenu.Show();
        }

        private void cboPermissao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cadastreSe_Load(object sender, EventArgs e)
        {

        }
    }
}
