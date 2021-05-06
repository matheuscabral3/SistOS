using System;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1.apresentacao
{
    public partial class frmMenu : Form
    {
        private readonly string TimeString;
        Thread th;


        public frmMenu()
        {
            InitializeComponent();
        }

        private void exibirPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openformperfil);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void cadastrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openformCadCliente);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void cadastrarTécnicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openformCadTecnico);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void cadastrarEquipamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openformCadEquip);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void emitirOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openformCadOS);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void trocaUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openformCadUsuario);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openformperfil()
        {
            Application.Run(new frmPerfil());
        }

        private void openformCadCliente()
        {
            Application.Run(new frmCadCliente());
        }

        private void openformCadTecnico()
        {
            Application.Run(new frmCadTecnico());
        }

        private void openformCadEquip()
        {
            Application.Run(new frmCadEquipamento());
        }

        private void openformCadOS()
        {
            Application.Run(new frmOrdens());
        }

        private void openformCadUsuario()
        {
            Application.Run(new frmTelaLogin());
        }
    }
}