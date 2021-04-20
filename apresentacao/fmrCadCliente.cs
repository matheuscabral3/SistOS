﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.dal;

namespace WindowsFormsApp1.apresentacao
{
    public partial class fmrCadCliente : Form
    {
        frmMenu frmMenu = new frmMenu();
        conexao con = new conexao();
        SqlCommand cmd = new SqlCommand();
        public fmrCadCliente()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMenu.Show();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "INSERT INTO tbClientes(nome, cidade, email, telefone, endereco) VALUES(@nome, @cidade, @email, @telefone, @endereco)";
            cmd.Parameters.AddWithValue("@nome", this.txbNome.Text);
            cmd.Parameters.AddWithValue("@cidade", this.txbCidade.Text);
            cmd.Parameters.AddWithValue("@email", this.txbEmail.Text);
            cmd.Parameters.AddWithValue("@telefone", this.txbTel.Text);
            cmd.Parameters.AddWithValue("@endereco", this.txbEnd.Text);

            //Executar
            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();
                MessageBox.Show("Cliente Cadastrado com Sucesso");

            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao Cadastrar Cliente");
            }
        }

        private void fmrCadCliente_Load(object sender, EventArgs e)
        {

        }

        private void ValidarControles()
        {
            if (txbNome.Text == "" || txbCidade.Text == "" || txbEmail.Text == "" || txbEnd.Text == "" || txbTel.Text == "")
            {
                MessageBox.Show("Preencha todos os campos !", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
