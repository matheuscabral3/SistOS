using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.dal;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WindowsFormsApp1.modelo
{
    public class controle
    {
        public bool tem = false; //
        public string mensagem = "";
        conexao con = new conexao();
        LoginDaoComandos loginDao = new LoginDaoComandos();

        //2 Métodos(Acessar, Cadastrar uma pessoa)
        public bool acessar(string login, string senha) //Retornar Op. Lógico SIM ou NÂO
        {
            tem = loginDao.verificarLogin(login, senha);//Método verificarLogin da classe LoginDaoComandos
            if (!loginDao.mensagem.Equals(""))//MENSAGEM de ERRO armazenada > Não Sucesso
            {
                this.mensagem = loginDao.mensagem;
            }
            return tem; //SIM > Tem mensagem
        }
        public string cadastrar(string email, string senha, string confSenha, string permissao) //Retornar STRING
        {
            int index = Convert.ToInt32(permissao);
            this.mensagem = loginDao.cadastrar(email, senha, confSenha, index);
            if (loginDao.tem) //a mensagem que vai vir é de Sucesso
            {
                this.tem = true;
            }
            return mensagem;
        }
    }
}
