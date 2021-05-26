using System;
using System.Windows.Forms;
using WindowsFormsApp1.apresentacao;
using WindowsFormsApp1.modelo;
using WindowsFormsApp1.dal;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmCadEquipamento());
        }
    }
}
