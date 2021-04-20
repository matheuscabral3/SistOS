using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class cadastro
    {
        SqlCommand cmd = new SqlCommand(); //Instânciar o comando
        conexao conexao = new conexao(); //Instânciar a conexão
        public string mensagem = "";
        //1º Método Construtor
        public cadastro(string email, string senha, string confSenha)
        {
            //2º Comando SQL - Precisa de uma classe para escrever os comandos SqlCommand (insert, update, delete)
            cmd.CommandText = "INSERT INTO logins(email, senha) VALUES(@email, @senha)"; //Comando em Forma de Texto

            //3º Parâmetros
            cmd.Parameters.AddWithValue("@email",email); //Adicionar os Parâmetros 2(parametros) 1 string e o valor
            cmd.Parameters.AddWithValue("@senha",senha);
         
            //Executar as linhas acima
            try
            {
                cmd.Connection = conexao.conectar(); //Conectando ao endereço passado na CONEXÃO

                //5º Executar o comando que queremos
                cmd.ExecuteNonQuery();//apenas para enviar informação, se quiser pegar informação (cmd.ExecuteReader)

                //6º Desconectar com o banco de dados
                conexao.desconectar();

                //7º Mostrar mensagem de Erro ou Sucesso - Variável STRING para guardar mensagem de ERRO ou SUCESSO
                this.mensagem = "Cadastrado com Sucesso !!!";//Guardar a mensagem de erro ou sucesso
            }
            catch (SqlException)//Caso ocorra algum erro no TRY, cai no CATCH. Exception(Genérico) por isso SqlException(erro no SQL)
            {
                this.mensagem = "Erro ao tentar conectar com o Banco de Dados";
            } 
            
        }
    }
}
