using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_delivery.Conexão;
using test_delivery.Modelo;

namespace test_delivery.Modelo
{
    public class Login
    {
        public string mensagem = "";
        public bool tem;
        public bool Logar(string login, string senha, string cargo)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            tem = loginDao.verificarLogin(login, senha, cargo);
            if (!loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem;
            }
            return tem;

        }

        
    }
}
