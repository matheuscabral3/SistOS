﻿using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public class conexao
    {
        SqlConnection con = new SqlConnection();
        //construtor
        public conexao()
        {
            //Endereço da conexão, adicionar o "@" para não dar erro
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Gamer\source\repos\Projeto Local SistOS\BD\RATBanco.mdf;Integrated Security=True;Connect Timeout=30";
        }

        //1º Método para conectar com o banco de dados
        public SqlConnection conectar()
        {
            //Verificar se já está conectado? se estiver aberta não precisa conectar...
            if (con.State == System.Data.ConnectionState.Closed)//Se estiver fechada, vai conectar
            {
                con.Open();
            }
            return con;//Devolver a conexão
        }

        //2º Método para desconectar com o banco de dados
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)//Se estiver aberta, vai desconectar
            {
                con.Close();
            }
            //Return con; //- NÃO é necessário devolver a conexão fechada !
        }
    }
}
