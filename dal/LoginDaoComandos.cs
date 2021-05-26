using System;
using System.Data.SqlClient;

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

                if (senha != "")
                {
                    //VERIFICAÇÃO DE ACESSO
                    cmd.CommandText = "SELECT * FROM tbUsuarios WHERE usuarios ='" + login + "' " + "AND senha='" + senha + "';";
                }
                else
                {
                    //VERIFICAÇÃO DE INCLUSÃO - SELECT > INSERT
                    cmd.CommandText = "SELECT * FROM tbUsuarios WHERE usuarios ='" + login + "'; ";
                }

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
                if (permissao == 1 || permissao == 2)
                {
                    //CADASTRAR GERENTE
                    cmd.CommandText = "INSERT INTO tbUsuarios(usuarios, senha, permissao) " +
                    "VALUES(@email, @senha, " + permissao + ");";

                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@senha", senha);
                    // cmd.Parameters.AddWithValue("@permissao", permissao);

                    try
                    {
                        //cmd.CommandText = "INSERT INTO tbUsuarios(usuarios, senha, permissao) VALUES('" + email + "', '" + senha + "','" + permissao + "');";
                        cmd.Connection = con.conectar();
                        cmd.ExecuteNonQuery();
                        con.desconectar();
                        this.mensagem = "Cadastrado com Sucesso !";
                    }
                    catch (Exception)//Mensagem Erro de Cadastro
                    {
                        this.mensagem = "Erro ao Cadastrar.";
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
                        this.mensagem = "Cadastrado com Sucesso !";
                        //tem = true;
                    }
                    catch (Exception)//Mensagem Erro de Cadastro
                    {
                        this.mensagem = "Erro ao cadastrar.";
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
        public string excluir(string email, string senha)
        {
            if (email == "" || senha == "")
            {
                this.mensagem = "Inserir as informações do usuário para exclusão !";
                return mensagem;
            }


            try
            {
                cmd.CommandText = "DELETE FROM tbUsuarios WHERE usuarios = '" + email + "' AND senha = '" + senha + "';";

                cmd.Connection = con.conectar(); //Abrir conexão
                cmd.ExecuteNonQuery(); //Executar Comando
                con.desconectar(); //Fechar Conexão
                this.mensagem = "Registro Excluido com Sucesso !!";
                //tem = true;
            }
            catch (Exception)//Mensagem Erro de Cadastro
            {
                this.mensagem = "Erro ao Excluir usuário no Banco de Dados !";
            }
            return mensagem; //Retornar mensagem "Cadastrado com sucesso" ou "Erro de Cadastro"
        }

        public string alterar(string email, string senha, int permissao, string usuarioAntigo, string senhaAntiga)
        {
            //VALIDAR LÓGICA DE ALTERAÇÃO
            cmd.CommandText = "UPDATE tbUsuarios SET usuarios = @usuarios, senha = @senha, permissao = " + permissao +
            " WHERE usuarios = @usuarioAntigo  AND senha = @senhaAntiga;";

            cmd.Parameters.AddWithValue("@usuarios", email);
            cmd.Parameters.AddWithValue("@senha", senha);
            cmd.Parameters.AddWithValue("@usuarioAntigo", usuarioAntigo);
            cmd.Parameters.AddWithValue("@senhaAntiga", senhaAntiga);

            //Executar
            try
            {
                //cmd.CommandText = "UPDATE tbUsuarios SET usuarios = '" + email + "', senha = '" + senha + "', permissao = " + permissao + " WHERE senha = '" + senhaAntiga + "';";
                cmd.Connection = con.conectar(); //Abrir conexão
                cmd.ExecuteNonQuery(); //Executar Comando
                con.desconectar(); //Fechar Conexão
                this.mensagem = "Registro Alterado com Sucesso !!";
            }
            catch (Exception)//Mensagem Erro de Cadastro
            {
                this.mensagem = "Erro ao Alterar usuário no Banco de Dados !";
            }
            return mensagem; //Retornar mensagem "Cadastrado com sucesso" ou "Erro de Cadastro"
        }
    }
}
