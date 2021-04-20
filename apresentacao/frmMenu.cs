using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.apresentacao
{
    public partial class frmMenu : Form
    {
        private readonly string TimeString;

        public frmMenu()
        {
            InitializeComponent();
        }

        private void exibirPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPerfil editarPerfil = new frmPerfil();
            this.Hide();
            editarPerfil.Show();
        }

        private void cadastrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmrCadCliente cad = new fmrCadCliente();
            this.Hide();
            cad.Show();
        }

        private void cadastrarTécnicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmrCadTecnico cadTecnico = new fmrCadTecnico();
            this.Hide();
            cadTecnico.Show();
        }

        private void cadastrarEquipamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmrCadEquipamento cadEquipamento = new fmrCadEquipamento();
            this.Hide();
            cadEquipamento.Show();
        }

        private void emitirOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmrOrdens ordens = new fmrOrdens();
            this.Hide();
            ordens.Show();
        }

        private void consultarEquipamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}