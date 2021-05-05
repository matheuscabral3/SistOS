using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.dal
{
    public class LoginDaoComandos
    {
        public bool tem = false; //Passa a ser verdadeiro, se já TEM cadastrado
        public string mensagem = ""; //Se estiver vazia, então o SELECT ocorreu com êxito
        SqlCommand cmd = new SqlCommand();//Instância do Comando SQL
        conexao con = new conexao();//Instância da Conexão SQL
        SqlDataReader dr;//Criar a variável para armazenar o SELECT(informação)

        //Método vai ir no banco de dados e verificar se já está cadastrado.
        public bool verificarLogin(string login, string senha)//Verificar no Banco de Dados, se possui valor com esse parâmetro
        {
            try
            {
                cmd.CommandText = "SELECT * FROM tbUsuarios WHERE email ='" + login + "' AND senha='" + senha + "';";
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();  //Pegar a informação e guardar em algum lugar ? ==> dr;
                if (dr.HasRows)  //se foi encontrado
                {
                    tem = true;
                }
                con.desconectar();
                dr.Close();
            }
            catch (SqlException)
            {
                this.mensagem = "Usuário não encontrado"; //Mensagem de Erro
            }

            return tem;
        }

        //Método Cadastrar
        public string cadastrar(string email, string senha, string confSenha, int permissao)
        {
            //CADASTRAR FUNCIONÁRIO / USUÁRIO
            if (senha.Equals(confSenha)) //Senha e confSenha precisam ser iguais
            {
                //LÓGICA para VALIDAR PERMISSÕES e CADASTRAR
                if (permissao == 1)
                {
                    //CADASTRAR GERENTE
                    try
                    {
                        cmd.CommandText = "INSERT INTO tbUsuarios(email, senha, permissao) VALUES('" + email + "', '" + senha + "','" + permissao + "');";

                        cmd.Connection = con.conectar();
                        cmd.ExecuteNonQuery();
                        con.desconectar();
                        this.mensagem = "Gerente Cadastrado com Sucesso !";
                        tem = true;
                    }
                    catch (Exception)//Mensagem Erro de Cadastro
                    {
                        this.mensagem = "Erro ao Cadastrar Gerente.";
                    }
                }
                else if (permissao == 2)
                {
                    //CADASTRAR USUÁRIO / FUNCIONÁRIO
                    try
                    {
                        cmd.CommandText = "INSERT INTO tbUsuarios(usuarios, senha, permissao) VALUES('" + email + "', '" + senha + "','" + permissao + "');";

                        cmd.Connection = con.conectar(); //Abrir conexão
                        cmd.ExecuteNonQuery(); //Executar Comando
                        con.desconectar(); //Fechar Conexão
                        this.mensagem = "Funcionário Cadastrado com Sucesso !";
                        tem = true;
                    }
                    catch (Exception)//Mensagem Erro de Cadastro
                    {
                        this.mensagem = "Erro ao cadastrar funcionário.";
                    }
                }
            }
            else
            {
                this.mensagem = "Senhas Não Correspondem.";
            }
            return mensagem;
        }

        //MÉTODO EXCLUIR
        public string excluir(string email)
        {
            try
            {
                cmd.CommandText = "DELETE FROM tbUsuarios WHERE usuarios = '" + email + "';";

                cmd.Connection = con.conectar(); //Abrir conexão
                cmd.ExecuteNonQuery(); //Executar Comando
                con.desconectar(); //Fechar Conexão
                this.mensagem = "Excluido com Sucesso !!";
                tem = true;
            }
            catch (Exception)//Mensagem Erro de Cadastro
            {
                this.mensagem = "Erro ao Excluir usuário no Banco de Dados !";
            }
            return mensagem; //Retornar mensagem "Cadastrado com sucesso" ou "Erro de Cadastro"
        }
        
        public string alterar(string email, string senha, int permissao, string senhaAntiga)
        {
            try
            {

                cmd.CommandText = "UPDATE tbUsuarios SET usuarios = '" + email + "', senha = '" + senha + "', permissao = " + permissao + " WHERE senha = '" + senhaAntiga + "';" ;

                cmd.Connection = con.conectar(); //Abrir conexão
                cmd.ExecuteNonQuery(); //Executar Comando
                con.desconectar(); //Fechar Conexão
                this.mensagem = "Registro Alterado com Sucesso !!";
                tem = true;
            }
            catch (Exception)//Mensagem Erro de Cadastro
            {
                this.mensagem = "Erro ao Alterar usuário no Banco de Dados !";
            }
            return mensagem; //Retornar mensagem "Cadastrado com sucesso" ou "Erro de Cadastro"
        }
    }
}
